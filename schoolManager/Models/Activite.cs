﻿namespace schoolManager.Models
{
    public class Activite
    {
        private int ects;
        private string name;
        private string code;
        public string Uid { get; set;}
        private string UidTeacher{get;set;}
        private static List<Activite> listActivite = new List<Activite>();

        public Activite(string name, string code, string uidTeacher, int ects)
        {
            this.name = name;
            this.code = code;
            Uid = GenerateNewUid();
            UidTeacher = uidTeacher;
            this.ects = ects;
            listActivite.Add(this);
        }

        public static Activite findActivite(string UID)
        {
            Guid myGuid;
            if (Guid.TryParse(UID, out myGuid))
            {
                if (myGuid == Guid.Empty)
                {
                    return new Activite("/","/","/",0);
                }
            }
            foreach (Activite activite in listActivite)
            {
                if (activite.Uid == UID)
                {
                    return activite;
                }
            }
            return new Activite("/","/","/",0);
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

        public Enseignant EnseignantObj
        {
            get { return Enseignant.findEnseignant(UidTeacher); }
            set { UidTeacher = value.Uid; }
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
        private static string GenerateNewUid()
        {
            string newUid;
            bool isUnique;

            do
            {
                // Generate a new UID
                newUid = Guid.NewGuid().ToString();

                // Check if the UID is unique
                isUnique = !listActivite.Any(obj => obj.Uid == newUid);

            } while (!isUnique);

            return newUid;
        }
    }
}
