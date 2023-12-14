//ICI tous les services qui vont call les methodes de DAL  
//qui vont etres utilises par lapp
//a faire: save ,load ,modfiy(immuable?)
//
using Newtonsoft.Json;
using schoolManager.DAL;
using schoolManager.Models;

namespace schoolManager.Services
{
    public class AppServices
    {
        private Dictionary<string, List<string>> data;
        public List<Activite> listActivite;
        public List<Enseignant> listEnseignant;
        public List<Etudiant> listEtudiant;
        public List<Eval> listEval;
        public List<Person> listPerson;
        public List<Appreciation> listAppreciation;
        public List<Cote> listCote;
        private string filePath;
        //METHODES PUBLIQUES
        public AppServices()
        {
            //constructor : makes the file path and then calls intit
            filePath = "ICI LE FILE PATH PR LE JSON/data_Backup_Of_23-12-13_16:34:08";
            InitializeData();
        }
        public void SaveChanges()
        {
            //make new data from all lists of objects
            //pack all data
            //EXEMPLE DATA
            // Dictionary<string, List<string>> packedData = new Dictionary<string, List<string>>
            // {
            //     { "Activite", new List<string> { "Value11", "Value12", "Value13" } },
            //     { "Appreciation", new List<string> { "Value21", "Value22" } },
            //     { "Cote", new List<string> { "Value31", "Value32", "Value33", "Value34" } }
            // };
            Dictionary<string, List<string>> packedData = packAll();
            JsonDataAccess.WriteDictionaryToFile(packedData,JsonDataAccess.GenerateBackupName());
        }

        // NEW OBJECTS METHODS(constructors)
        public Activite createActivite(string Name,string Code,Enseignant enseignant,int ECTS){
            Activite activite = new Activite(Name,Code,enseignant,ECTS,listActivite);
            return activite;
        }
        public Appreciation createAppreciation(string appreciationSTR,Activite activite){
            Appreciation appreciation = new Appreciation(appreciationSTR,activite,listAppreciation,listEval);
            return appreciation;
        }
        public Cote createCote(int note,Activite activite){
            Cote cote = new Cote(note,activite,listCote,listEval);
            return cote;
        }
        public Enseignant createEnseignant(int salaire,string firstName,string lastName){
            Enseignant enseignant = new Enseignant(salaire,firstName,lastName,listEnseignant,listPerson);
            return enseignant;
        }
        public Etudiant createEtudiant(string firstName,string lastName,List<Eval> evaluations){
            Etudiant etudiant = new Etudiant(firstName,lastName,evaluations,listEtudiant,listPerson);
            return etudiant;
        }
        //METHODES PRIVEES
        private void InitializeData()
        {
            //gets data from json file, creates all lists then unpacks the dictionary to create instances of objects
            data = JsonDataAccess.ReadDictionaryFromFile(filePath);
            listActivite = new List<Activite>{};
            listEnseignant = new List<Enseignant>{};
            listEtudiant = new List<Etudiant>{};
            listEval = new List<Eval>{};
            listPerson = new List<Person>{};
            unpackAll(data);
        }
        //packer and unpackers
        private Dictionary<string, List<string>> packAll()
        {
            List<string> dicoKeys = new List<string>{"Etudiant","Enseignant","Cote","Appreciation","Activite"};
            Dictionary<string, List<string>> output = new Dictionary<string, List<string>>{};
            foreach (string keyName in dicoKeys)
            {
                switch (keyName)
                {
                    case "Etudiant":
                        List<string> packedObjectListEtudiant = new List<string>{};
                        foreach (object packableItem in listEtudiant)
                        {
                            packedObjectListEtudiant.Add(pack(packableItem));
                        }
                        output[keyName] = packedObjectListEtudiant;
                        break;

                    case "Enseignant":
                        List<string> packedObjectListEnseignant = new List<string>{};
                        foreach (object packableItem in listEnseignant)
                        {
                            packedObjectListEnseignant.Add(pack(packableItem));
                        }
                        output[keyName] = packedObjectListEnseignant;
                        break;

                    case "Cote":
                        List<string> packedObjectListCote = new List<string>{};
                        foreach (object packableItem in listCote)
                        {
                            packedObjectListCote.Add(pack(packableItem));
                        }
                        output[keyName] = packedObjectListCote;
                        break;
                    case "Appreciation":
                        List<string> packedObjectListAppreciation = new List<string>{};
                        foreach (object packableItem in listAppreciation)
                        {
                            packedObjectListAppreciation.Add(pack(packableItem));
                        }
                        output[keyName] = packedObjectListAppreciation;
                        break;
                    case "Activite":
                        List<string> packedObjectListActivite = new List<string>{};
                        foreach (object packableItem in listActivite)
                        {
                            packedObjectListActivite.Add(pack(packableItem));
                        }
                        output[keyName] = packedObjectListActivite;
                        break;

                    default:
                        Console.WriteLine("how did we get here?");
                        break;
                }
            }
            return output;
        } 
        private string pack(object item)
        {
            //take any object and make it into a dictionary
            //using the newton soft soft lib
            string output = JsonConvert.SerializeObject(item);
            return output;
        }
        private void unpackAll(Dictionary<string, List<string>> data)
        {
            //call all unpackers with a switch case and consequently generate alll objects
            // unpacking order MUST BE :  Enseignant => Activite => Evaluations (cotes,appreciations packed into a list) => Etudiants

            //for the appreciations and cotes maybe add attribute id that represents from which student the eval is so that you can associate it with after

            //enseignant
            // Check if the key exists in the dictionary
            if (data.ContainsKey("Enseignant"))
            {
                // Retrieve the list associated with the key
                List<string> enseignantList = data["Enseignant"];

                // Iterate through the items in the list
                foreach (string item in enseignantList)
                {
                    Console.WriteLine($"created {unpackEnseignant(item).ToString()} object");
                }
            }
            else
            {
                Console.WriteLine($"Key 'Enseignant' not found in the dictionary.");
            }

            //Activite
            if (data.ContainsKey("Activite"))
            {
                // Retrieve the list associated with the key
                List<string> activiteList = data["Activite"];

                // Iterate through the items in the list
                foreach (string item in activiteList)
                {
                    Console.WriteLine($"created {unpackActivite(item).ToString()} object");
                }
            }
            else
            {
                Console.WriteLine($"Key 'Activite' not found in the dictionary.");
            }

            //Cote
            if (data.ContainsKey("Cote"))
            {
                // Retrieve the list associated with the key
                List<string> coteList = data["Cote"];

                // Iterate through the items in the list
                foreach (string item in coteList)
                {
                    Console.WriteLine($"created {unpackCote(item).ToString()} object");
                }
            }
            else
            {
                Console.WriteLine($"Key 'Cote' not found in the dictionary.");
            }

            //Appreciation
            if (data.ContainsKey("Appreciation"))
            {
                // Retrieve the list associated with the key
                List<string> appreciationList = data["Appreciation"];

                // Iterate through the items in the list
                foreach (string item in appreciationList)
                {
                    Console.WriteLine($"created {unpackAppreciation(item).ToString()} object");
                }
            }
            else
            {
                Console.WriteLine($"Key 'Appreciations' not found in the dictionary.");
            }

            //Etudiant
            if (data.ContainsKey("Etudiant"))
            {
                // Retrieve the list associated with the key
                List<string> etudiantList = data["Etudiant"];

                // Iterate through the items in the list
                foreach (string item in etudiantList)
                {
                    Console.WriteLine($"created {unpackEtudiant(item).ToString()} object");
                }
            }
            else
            {
                Console.WriteLine($"Key 'Etudiant' not found in the dictionary.");
            }
   
        }
        
        private Activite unpackActivite(string packedItem)
        {
            //unpack object
            Activite activite = JsonConvert.DeserializeObject<Activite>(packedItem);
            return activite;
        }
        private Appreciation unpackAppreciation(string packedItem)
        {
            //unpack object

            Appreciation appreciation = JsonConvert.DeserializeObject<Appreciation>(packedItem);
            return appreciation;
        }
        private Cote unpackCote(string packedItem)
        {
            //unpack object

            Cote cote = JsonConvert.DeserializeObject<Cote>(packedItem);
            return cote;
        }
        private Enseignant unpackEnseignant(string packedItem)
        {
            //unpack object

            Enseignant enseignant = JsonConvert.DeserializeObject<Enseignant>(packedItem);
            return enseignant;
        }
        private Etudiant unpackEtudiant(string packedItem)
        {
            //unpack object

            Etudiant etudiant = JsonConvert.DeserializeObject<Etudiant>(packedItem);
            return etudiant;
        }

    }
}
