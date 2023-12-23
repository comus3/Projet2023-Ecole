//the new way!!!
// dictionnaire de dictionnaire pour enregistrer donnees
// doit pouvoir au moins creer et supprimer des donnees
//les donnees sont des dictionnaires de dictionnaires
//chaque key du dico ext est le type d'objet,
//chaque chaque value du dico ext est une instance de l'objet(rep par un dico)
//chaque value-key int du dico rep ses attributs
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using schoolManager.Services;

namespace schoolManager.DAL
{
    public class JsonDataAccess
    {
        public static string GenerateBackupName()
        {
            // Create a string with the format "data_Backup_Of_23-12-13_16_34_08"
            string prefix = "data_Backup_Of_";
            string timestamp = DateTime.Now.ToString("yy-MM-dd_HH_mm_ss");
            
            // Combine all parts to form the final name
            string backupName = $"{prefix}{timestamp}";

            return backupName;
        }

        public static Dictionary<string, List<string>> ReadDictionaryFromFile(string fileName)
        {
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

            try
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    string line;
                    string currentKey = null;
                    List<string> currentList = new List<string>();

                    while ((line = reader.ReadLine()) != null)
                    {
                        if (string.IsNullOrWhiteSpace(line))
                        {
                            // Empty line indicates the end of the current entry
                            if (currentKey != null)
                            {
                                dictionary.Add(currentKey, currentList);
                                currentKey = null;
                                currentList = new List<string>();
                            }
                        }
                        else
                        {
                            if (currentKey == null)
                            {
                                // First non-empty line is the key
                                currentKey = line;
                            }
                            else
                            {
                                // Subsequent non-empty lines are values in the list
                                currentList.Add(line);
                            }
                        }
                    }

                    // Add the last entry if it exists
                    if (currentKey != null)
                    {
                        dictionary.Add(currentKey, currentList);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return dictionary;
        }
        public static void WriteDictionaryToFile(string fileName, Dictionary<string, List<string>> dictionary)
        {
            try
            {
                string directoryPath = AppServices.directoryPath; // Update this with your actual directory path

                // Ensure the directory exists, create it if necessary
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                // Combine the directory path and file name
                string fullPath = Path.Combine(directoryPath, fileName);

                // Write to the specified file path
                using (StreamWriter writer = new StreamWriter(fullPath))
                {
                    foreach (var entry in dictionary)
                    {
                        // Write the key
                        writer.WriteLine(entry.Key);

                        // Write each item in the list
                        foreach (var item in entry.Value)
                        {
                            writer.WriteLine(item);
                        }

                        // Separate entries with an empty line
                        writer.WriteLine();
                    }
                }

                Console.WriteLine($"Backup written to: {fullPath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
