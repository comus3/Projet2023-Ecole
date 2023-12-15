using schoolManager.Models;

namespace schoolManager.Testing{
    class Testing{
        public void init(){
            Enseignant Lurking = new Enseignant(10000,"Quentin","Lurk1");
            Enseignant DLH = new Enseignant(15000,"Quentin","Delhaye");

            Activite Info = new Activite("INFO","INFO3000",Lurking,5);
            Activite Elec = new Activite("ELEC ANAL","ANAL3000",DLH,5);
            Activite ElecNum = new Activite("ELEC NUM","NUM3000",DLH,3);

            List<Eval> evaluations = new List<Eval>{
                new Appreciation("TB",Info),
                new Appreciation("B",Elec),
                new Cote(14,ElecNum)
            };
 
            Etudiant Baptiste = new Etudiant("Batou","Chouchou",evaluations);
        }
    }
}