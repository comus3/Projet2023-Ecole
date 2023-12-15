namespace schoolManager.Models
{
    public abstract class Eval
    {
        private Activite activite;
        private static List<Eval> listEval = new List<Eval>();

        public Eval(Activite activite)
        {
            this.activite = activite;
            listEval.Add(this);
        }

        public Activite Activite
        {
            get { return activite; }
            set { activite = value; }
        }

        public abstract int Note();

        public static List<Eval> ListEval
        {
            get { return listEval; }
        }
    }
}
