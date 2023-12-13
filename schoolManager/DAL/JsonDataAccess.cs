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
using Newtonsoft.Json;

namespace schoolManager.DAL
{
    public class JsonDataAccess
    {
        private readonly string filePath;

        public JsonDataAccess(string filePath)
        {
            this.filePath = filePath;
        }

        public Dictionary<string, List<Dictionary<string,string>>> LoadData()
        {
            try
            {
                if (File.Exists(filePath))
                {
                    var json = File.ReadAllText(filePath);
                    return JsonConvert.DeserializeObject<Dictionary<string, List<Dictionary<string,string>>>>(json);
                }
                else
                {
                    throw new Exception($"File not found at path: {filePath}");
                }
            }
            catch (JsonException ex)
            {
                Console.WriteLine($"Error deserializing JSON from file {filePath}: {ex.Message}");
                return new Dictionary<string, List<Dictionary<string,string>>>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                return new Dictionary<string, List<Dictionary<string,string>>>();
            }
        }
        public void SaveData(Dictionary<string, List<Dictionary<string,string>>> data){
            
        }




    }
}
