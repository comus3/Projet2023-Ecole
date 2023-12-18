using schoolManager.DAL;
using schoolManager.Services;
using schoolManager.Models;

namespace schoolManager.Program
{
    class Program
    {
        public static void Init(){
            // Teachers
            Enseignant lurk1 = new Enseignant(10000, "Quentin", "Lurk1");
            Enseignant dlh = new Enseignant(15000, "Quentin", "Delhaye");
            Enseignant lurk2 = new Enseignant(12000, "Lucas", "Lurk2");
            Enseignant creativeTeacher = new Enseignant(18000, "Aria", "CreativeTeacher");

            // Courses
            Activite info = new Activite("INFO", "INFO3000", lurk1.Uid, 5);
            Activite elecAnal = new Activite("ELEC ANAL", "ANAL3000", dlh.Uid, 5);
            Activite elecNum = new Activite("ELEC NUM", "NUM3000", dlh.Uid, 3);
            Activite algo = new Activite("ALGO", "ALGO3000", Guid.Empty.ToString(), 4);
            Activite creativityClass = new Activite("CREATIVITY", "CRTV3000", creativeTeacher.Uid, 5);


            // Students
            Etudiant baptiste = new Etudiant("Batou", "Chouchou");
            Etudiant lucasStudent = new Etudiant("Lucas", "Smith");
            Etudiant ariaStudent = new Etudiant("Aria", "Johnson"); 
            // Evaluations
            new Appreciation("TB", info.Uid,baptiste.UidStudent);
            new Appreciation("B", elecAnal.Uid,baptiste.UidStudent);
            new Cote(14, elecNum.Uid,baptiste.UidStudent);
            // Add more evaluations for Baptiste

            new Appreciation("B", algo.Uid,lucasStudent.UidStudent);
            new Appreciation("B", creativityClass.Uid,lucasStudent.UidStudent);
            // Add more evaluations for Lucas

            new Appreciation("B", creativityClass.Uid,ariaStudent.UidStudent);


            
            Console.WriteLine("objects created!");
        }
        public static void createJson()
        {
            Console.WriteLine("initiating objects!");
            Init();
            Console.WriteLine("Creating Json and writing it!");
            AppServices.SaveChanges();
        }
        public static void Main(string[] args)
        {
            //createJson();
            AppServices.loadData();
            Console.WriteLine("data read");
        }
    }
}