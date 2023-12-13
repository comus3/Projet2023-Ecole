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

        public void AppServices()
        {
            this.jsonDataAccess = new JsonDataAccess("ICI LE FILE PATH PR LE JSON");
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
            activite = new Activite(Name,Code,enseignant,ECTS,List<Activite> listActivite);
            return activite;
        }
        public Appreciation createAppreciation(string appreciation,Activite activite){
            appreciation = new Appreciation(appreciation,activite);
            return appreciation;
        }
        public Cote createCote(int note,Activite activite){
            cote = new Cote(note,activite);
            return cote;
        }
        public Enseignant createEnseignant(int salaire,string firstName,string lastName){
            enseignant = new Enseignant(salaire,firstName,lastName,listEnseignant);
            return enseignant;
        }
        public Etudiant createEtudiant(string firstName,string lastName,List<Eval> evaluations){
            etudiant = new Etudiant(firstName,lastName,evaluations,listEtudiant);
            return etudiant;
        }
        public Cote createCote(int note,Activite activite){
            cote = new Cote(note,activite);
            return cote;
        }
        public Appreciation createAppreciation(string appreciation,Activite activite){
            appreciation = new Appreciation(appreciation,activite);
            return appreciation;
        }

    }
}
