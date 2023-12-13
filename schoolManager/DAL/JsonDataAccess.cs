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


namespace schoolManager.DAL
{
    public class JsonDataAccess
    {
        public static string GenerateBackupName()
        {
            // Create a string with the format "data_Backup_Of_23-12-13_16:34:08"
            string prefix = "data_Backup_Of_";
            string timestamp = DateTime.Now.ToString("yy-MM-dd_HH:mm:ss");
            
            // Combine all parts to form the final name
            string backupName = $"{prefix}{timestamp}";

            return backupName;
        }
        public static Dictionary<string, List<string>> ReadDictionaryFromFile(string filePath)
        {
            Dictionary<string, List<string>> resultDictionary = new Dictionary<string, List<string>>();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Assuming the file format is key:value1,value2,value3,...
                        string[] parts = line.Split(':');
                        string key = parts[0].Trim();
                        List<string> values = new List<string>(parts[1].Split(','));

                        resultDictionary[key] = values;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while reading from the file: {ex.Message}");
            }
            return resultDictionary;
        }
        public static void WriteDictionaryToFile(Dictionary<string, List<string>> dictionary, string newfilePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(newfilePath))
                {
                    foreach (var kvp in dictionary)
                    {
                        // Writing key and values to the file in the format key:value1,value2,value3,...
                        string line = $"{kvp.Key}:{string.Join(",", kvp.Value)}";
                        writer.WriteLine(line);
                    }
                }

                Console.WriteLine($"Dictionary successfully written to {newfilePath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred while writing to the file: {ex.Message}");
            }
        }
    }
}
