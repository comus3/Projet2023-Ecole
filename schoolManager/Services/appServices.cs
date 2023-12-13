//ICI tous les services qui vont call les methodes de DAL  
//qui vont etres utilises par lapp
//a faire: save ,load ,modfiy(immuable?)
//
using schoolManager.DAL;
using schoolManager.Models;

namespace schoolManager.Services
{
    public class AppServices
    {
        private readonly JsonDataAccess jsonDataAccess;
        private Dictionary<string, List<Dictionary<string,string>>> data;
        public List<Activite> listActivite;
        public List<Enseignant> listEnseignant;
        public List<Etudiant> listEtudiant;
        public List<Eval> listEval;
        public List<Person> listPerson;

        public AppServices()
        {
            jsonDataAccess = new JsonDataAccess("ICI LE FILE PATH PR LE JSON/dataBackupOf23-12-13 16:34:08");
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

        // NEW OBJECTS METHODS(constructors)
        public Activite createActivite(string Name,string Code,Enseignant enseignant,int ECTS){
            Activite activite = new Activite(Name,Code,enseignant,ECTS,listActivite);
            return activite;
        }
        public Appreciation createAppreciation(string appreciationSTR,Activite activite){
            Appreciation appreciation = new Appreciation(appreciationSTR,activite,listEval);
            return appreciation;
        }
        public Cote createCote(int note,Activite activite){
            Cote cote = new Cote(note,activite,listEval);
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

    }
}
