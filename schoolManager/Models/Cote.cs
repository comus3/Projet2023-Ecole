namespace schoolManager.Models
{
    public class Cote : Eval
    {
        private int note;
        private static List<Cote> listCote = new List<Cote>();

        public Cote(int note, Activite activite) : base(activite)
        {
            this.note = note;
            listCote.Add(this);
        }

        public int NoteValue
        {
            get { return note; }
            set { note = value; }
        }

        public override int Note()
        {
            return note;
        }

        public static List<Cote> ListCote
        {
            get { return listCote; }
        }
    }
}
