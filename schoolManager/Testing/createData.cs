namespace schoolManager.Testing{
    class Testing{
        public void init(){
            Models.Enseignant Lurking = new Models.Enseignant(10000,"Quentin","Lurk1");
            Models.Enseignant DLH = new Models.Enseignant(15000,"Quentin","Delhaye");

            Models.Activite Info = new Models.Activite("INFO","INFO3000",Lurking,5);
            Models.Activite Elec = new Models.Activite("ELEC ANAL","ANAL3000",DLH,5);
            Models.Activite ElecNum = new Models.Activite("ELEC NUM","NUM3000",DLH,3);

            List<Models.Eval> evaluations = new List<Models.Eval>{
                new Models.Appreciation("TB",Info),
                new Models.Appreciation("B",Elec),
                new Models.Cote(14,ElecNum)
            };
 
            Models.Etudiant Baptiste = new Models.Etudiant("Batou","Chouchou",evaluations);

            Console.WriteLine(Baptiste.Bulletin());
        }
    }
}