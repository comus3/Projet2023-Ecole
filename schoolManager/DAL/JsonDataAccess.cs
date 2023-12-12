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
        private readonly string filePath;

        public JsonDataAccess(string filePath)
        {
            this.filePath = filePath;
        }

        public Dictionary<string, Dictionary<string, object>> LoadData()
        {
            if (File.Exists(filePath))
            {
                var json = File.ReadAllText(filePath);
                return JsonSerializer.Deserialize<Dictionary<string, Dictionary<string, object>>>(json);
            }
            else
            {
                return new Dictionary<string, Dictionary<string, object>>();
            }
        }

        public void SaveData(Dictionary<string, Dictionary<string, object>> data)
        {
            var json = JsonSerializer.Serialize(data);
            File.WriteAllText(filePath, json);
        }
    }
}
