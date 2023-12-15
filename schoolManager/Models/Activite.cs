#nullable enable

namespace schoolManager.Models
{
    public class Activite
    {
        private int ects;
        private string name;
        private string code;
        private Enseignant? enseignant;
        private static List<Activite> listActivite = new List<Activite>();

        public Activite(string name, string code, Enseignant enseignant, int ects)
        {
            this.name = name;
            this.code = code;
            this.enseignant = enseignant;
            this.ects = ects;
            listActivite.Add(this);
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Code
        {
            get { return code; }
            set { code = value; }
        }

        public Enseignant Enseignant
        {
            get { return enseignant; }
            set { enseignant = value; }
        }

        public int Ects
        {
            get { return ects; }
            set { ects = value; }
        }

        public static List<Activite> ListActivite
        {
            get { return listActivite; }
        }
    }
}
