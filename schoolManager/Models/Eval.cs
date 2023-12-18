namespace schoolManager.Models
{
    public abstract class Eval
    {
        private string Uid{ get; set;}
        private string UidStudent{ get; set;}
        private string UidActivite { get; set; }
        private static List<Eval> listEval = new List<Eval>();

        public Eval(string uidActivite,string uidStudent,string uid = "uninitiated")
        {
            if (uid == "uninitiated")
            {
                uid = GenerateNewUid();
            }
            UidActivite = uidActivite;
            UidStudent = uidStudent;
            Uid = uid;
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

        public Activite ActiviteObj
        {
            get { return Activite.findActivite(Uid); }
            set { UidActivite = value.Uid; }
        }

        public abstract int Note();

        public static List<Eval> ListEval
        {
            get { return listEval; }
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
