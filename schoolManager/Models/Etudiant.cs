namespace schoolManager.Models
{
    public class Etudiant : Person
    {
        private List<Eval> evaluations;
        private static List<Etudiant> listEtudiant = new List<Etudiant>();

        public Etudiant(string firstName, string lastName, List<Eval> evaluations) :
            base(firstName, lastName)
        {
            this.evaluations = evaluations;
            listEtudiant.Add(this);
        }

        public List<Eval> Evaluations
        {
            get { return evaluations; }
            set { evaluations = value; }
        }

        public void AddEvaluation(Eval eval)
        {
            evaluations.Add(eval);
        }

        public double Average()
        {
            int numOfEval = 0;
            int sumOfValues = 0;
            int sumOfECTS = 0;

            foreach (Eval eval in evaluations)
            {
                numOfEval += 1;
                sumOfValues += eval.Activite.Ects * eval.Note();
                sumOfECTS += eval.Activite.Ects;
            }

            return (double)sumOfValues / sumOfECTS / numOfEval;
        }

        public string Bulletin()
        {
            string output = "";

            foreach (Eval eval in evaluations)
            {
                output += string.Format("Pour le cours de {0}, vous avez une note de {1}. {2} Crédits",
                    eval.Activite.Name, eval.Note(), eval.Activite.Ects);
            }

            output += string.Format("Pour une fabuleuse moyenne de {0}. Bravo {1}!", Average(), DisplayName());
            return output;
        }

        public static List<Etudiant> ListEtudiant
        {
            get { return listEtudiant; }
        }
    }
}
