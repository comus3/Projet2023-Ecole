namespace schoolManager.Models
{
    public class Enseignant : Person
    {
        private int salaire;
        private static List<Enseignant> listEnseignant = new List<Enseignant>();

        public Enseignant(int salaire, string firstName, string lastName) :
            base(firstName, lastName)
        {
            this.salaire = salaire;
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
