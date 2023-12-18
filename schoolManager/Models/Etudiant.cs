namespace schoolManager.Models
{
    public class Etudiant : Person
    {
        private static List<Etudiant> listEtudiant = new List<Etudiant>();
        private string UidStudent{ get; set;}
        public Etudiant(string firstName, string lastName) :
            base(firstName, lastName)
        {
            UidStudent = GenerateNewUid();
            listEtudiant.Add(this);
        }

        public double Average()
        {
            int numOfEval = 0;
            int sumOfValues = 0;
            int sumOfECTS = 0;

            foreach (Eval eval in Eval.findStudentEvals(UidStudent))
            {
                int ECTS = eval.ActiviteObj.Ects;
                numOfEval += 1;
                sumOfValues += ECTS * eval.Note();
                sumOfECTS += ECTS;
            }

            return (double)sumOfValues / sumOfECTS / numOfEval;
        }

        public string Bulletin()
        {
            string output = "";

            foreach (Eval eval in Eval.findStudentEvals(UidStudent))
            {
                output += string.Format("Pour le cours de {0}, vous avez une note de {1}. {2} Crédits",
                    eval.ActiviteObj.Name, eval.Note(), eval.ActiviteObj.Ects);
            }

            output += string.Format("Pour une fabuleuse moyenne de {0}. Bravo {1}!", Average(), DisplayName());
            return output;
        }

        public static List<Etudiant> ListEtudiant
        {
            get { return listEtudiant; }
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
                isUnique = !listEtudiant.Any(obj => obj.UidStudent == newUid);

            } while (!isUnique);

            return newUid;
        }
    }
}
