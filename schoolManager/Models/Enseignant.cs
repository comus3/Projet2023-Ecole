using schoolManager.Services;

namespace schoolManager.Models
{
    public class Enseignant : Person
    {
        private string Uid { get; set;}
        private int salaire;
        private static List<Enseignant> listEnseignant = new List<Enseignant>();

        public static Enseignant findEnseignant(int UID)
        {
            for (Enseignant enseignant in listEnseignant)
            {
                if (enseignant.Uid == UID)
                {
                    return enseignant;
                }
            }
        }

        public Enseignant(int salaire, string firstName, string lastName) :
            base(firstName, lastName)
        {
            this.salaire = salaire;
            Uid = Guid.GenerateNewUid(listEnseignant);
            listEnseignant.Add(this);
        }

        public int Salaire
        {
            get { return salaire; }
            set { salaire = value; }
        }

        public void Raise(int amt)
        {
            salaire += amt;
        }

        public static List<Enseignant> ListEnseignant
        {
            get { return listEnseignant; }
        }
    }
}
