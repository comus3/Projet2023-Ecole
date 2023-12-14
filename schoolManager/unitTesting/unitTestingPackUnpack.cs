using Microsoft.VisualStudio.TestTools.UnitTesting;
using schoolManager.Services;
using schoolManager.Models;
using schoolManager.DAL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace YourTestsProject
{
    [TestClass]
    public class PackUnpackTests
    {
        [TestInitialize]
        public void TestInitialize()
        {
            // You can modify the file path for testing purposes
            appServices = new AppServices();
        }
        [TestMethod]
        public void unPackTester()
        {
            //ici en gros etant donne que on a pas de load(ca load tout seul au moment de la construction)
            //il faut tester si il a bien lu le fichier test
            //donc des asserts sur les listes d'objets pe?
        }

        [TestMethod]
        public void constructorTesters()
        {
            Enseignant Lurking = AppServices.createActivite(10000,"Quentin","Lurk1");
            Enseignant DLH = AppServices.createEnseignant(15000,"Quentin","Delhaye");

            Activite Info = AppServices.createActivite("INFO","INFO3000",Lurking,5);
            Activite Elec = AppServices.createActivite("ELEC ANAL","ANAL3000",DLH,5);
            Activite ElecNum = AppServices.createActivite("ELEC NUM","NUM3000",DLH,3);

            List<Eval> evaluations = new List<Eval>{
                AppServices.createAppreciation("TB",Info),
                AppServices.createAppreciation("B",Elec),
                AppServices.createCote(14,ElecNum)
            };
 
            Etudiant Baptiste = AppServices.createEtudiant("Batou","Chouchou",evaluations);
        }
        [TestMethod]
        public void packTesters()
        {
            AppServices.SaveChanges();
            //ici mettre un assert que le fichier a bien ete créé sur le dossier
        }
    }

}
