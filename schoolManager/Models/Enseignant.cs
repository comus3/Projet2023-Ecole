namespace schoolManager.Models
{
    public class Enseignant : Person
    {
        public string Uid { get; set;}
        private int salaire;
        private static List<Enseignant> listEnseignant = new List<Enseignant>();

        public Enseignant(int salaire, string firstName, string lastName,string uid = "uninitiated") :
            base(firstName, lastName)
        {
            if (uid == "uninitiated")
            {
                uid = GenerateNewUid();
            }
            this.salaire = salaire;
            Uid = uid;
            listEnseignant.Add(this);
        }

        public static Enseignant findEnseignant(string UID)
        {
            Guid myGuid;
            if (Guid.TryParse(UID, out myGuid))
            {
                if (myGuid == Guid.Empty)
                {
                    return new Enseignant(0,"/","/");
                }
            }
            foreach (Enseignant enseignant in listEnseignant)
            {
                if (enseignant.Uid == UID)
                {
                    return enseignant;
                }
            }
            return new Enseignant(0,"/","/");
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

        private static string GenerateNewUid()
        {
            string newUid;
            bool isUnique;

            do
            {
                // Generate a new UID
                newUid = Guid.NewGuid().ToString();

                // Check if the UID is unique
                isUnique = !listEnseignant.Any(obj => obj.Uid == newUid);

            } while (!isUnique);

            return newUid;
        }
    }
}
