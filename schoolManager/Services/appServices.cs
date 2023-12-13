//ICI tous les services qui vont call les methodes de DAL  
//qui vont etres utilises par lapp
//a faire: save ,load ,modfiy(immuable?)
//
using schoolManager.DAL;
using schoolManager.Models;

namespace schoolManager.Services
{
    public class AppSercices
    {
        private readonly JsonDataAccess jsonDataAccess;
        private Dictionary<string, List<Dictionary<string,string>>> data;
        public List<Activite> listActivite;
        public List<Enseignant> listEnseignant;
        public List<Etudiant> listEtudiant;
        public List<Eval> listEval;
        public List<Person> listPerson;




        public void ModelServices(JsonDataAccess jsonDataAccess)
        {
            this.jsonDataAccess = jsonDataAccess;
            InitializeData();
        }

        private void InitializeData()
        {
            data = jsonDataAccess.LoadData();
            listActivite = new List<Activite>{};
            listEnseignant = new List<Enseignant>{};
            listEtudiant = new List<Etudiant>{};
            listEval = new List<Eval>{};
            listPerson = new List<Person>{};
        }

        public void SaveChanges()
        {
            //make new data from all lists of objects
            jsonDataAccess.SaveData(data);
        }

        // Add methods for manipulating the data, e.g., adding, updating, deleting items
    }
}
