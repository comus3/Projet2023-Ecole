namespace schoolManager.Models
{
    public abstract class Eval
    {
        private string uid;
        private string uidStudent;
        private string uidActivite;
        private static List<Eval> listEval = new List<Eval>();

        public Eval(string uidActivite,string uidStudent,string uid = "uninitiated")
        {
            if (uid == "uninitiated")
            {
                uid = GenerateNewUid();
            }
            this.uidActivite = uidActivite;
            this.uidStudent = uidStudent;
            this.uid = uid;
            listEval.Add(this);
        }

        public static List<Eval> findStudentEvals(string uidStudent)
        {
            List<Eval> result = new List<Eval>();
            foreach (Eval eval in listEval)
            {
                if(uidStudent == eval.UidStudent)
                {
                    result.Add(eval);
                }
            }
            return result;
        }

        public Activite ActiviteObjGet()
        {
            return Activite.findActivite(Uid);
        }
        public void ActiviteObjSet(Activite activite)
        {
            UidActivite = activite.Uid;
        }

        public abstract int Note();

        public static List<Eval> ListEval
        {
            get { return listEval; }
        }
        public string Uid 
        {
            get{return uid;}
            set{uid = value;}
        }
        public string UidStudent 
        {
            get{return uidStudent;}
            set{uidStudent = value;}
        }
        public string UidActivite 
        {
            get{return uidActivite;}
            set{uidActivite = value;}
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
                isUnique = !listEval.Any(obj => obj.Uid == newUid);

            } while (!isUnique);

            return newUid;
        }
    }
}
