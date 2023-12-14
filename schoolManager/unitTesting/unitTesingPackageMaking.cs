using Microsoft.VisualStudio.TestTools.UnitTesting;
using schoolManager.Services;
using schoolManager.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace YourTestsProject
{
    [TestClass]
    public class AppServicesTests
    {
        private AppServices appServices;

        [TestInitialize]
        public void TestInitialize()
        {
            // You can modify the file path for testing purposes
            appServices = new AppServices();
        }

        [TestMethod]
        public void SaveChanges_WritesToFile()
        {
            // Arrange
            string filePath = "testFile.json";
            appServices = new AppServices(); // Reinitialize to clear previous state
            appServices.SaveChanges();

            // Act
            Dictionary<string, List<string>> data = JsonDataAccess.ReadDictionaryFromFile(filePath);

            // Assert
            Assert.IsNotNull(data);
            // You may want to add assertions to check if the file has been written correctly
            File.Delete(filePath); // Clean up the test file
        }

        [TestMethod]
        public void CreateActivite_ReturnsActiviteObject()
        {
            // Arrange
            string activiteName = "Math";
            string activiteCode = "MATH101";
            Enseignant enseignant = new Enseignant(50000, "John", "Doe");
            int ECTS = 3;

            // Act
            Activite activite = appServices.createActivite(activiteName, activiteCode, enseignant, ECTS);

            // Assert
            Assert.IsNotNull(activite);
            Assert.AreEqual(activiteName, activite.Name);
            Assert.AreEqual(activiteCode, activite.Code);
            Assert.AreEqual(enseignant, activite.Enseignant);
            Assert.AreEqual(ECTS, activite.ECTS);
        }

        // Add similar tests for other Create methods and any other public methods in AppServices

        [TestMethod]
        public void UnpackEnseignant_CreatesEnseignantObject()
        {
            // Arrange
            string packedEnseignant = "{\"Salaire\":50000,\"FirstName\":\"John\",\"LastName\":\"Doe\"}";

            // Act
            Enseignant enseignant = appServices.unpackEnseignant(packedEnseignant);

            // Assert
            Assert.IsNotNull(enseignant);
            Assert.AreEqual(50000, enseignant.Salaire);
            Assert.AreEqual("John", enseignant.FirstName);
            Assert.AreEqual("Doe", enseignant.LastName);
        }

        // Add similar tests for other unpack methods

        [TestMethod]
        public void UnpackAll_CreatesObjects()
        {
            // Arrange
            string filePath = "testData.json";
            appServices = new AppServices(); // Reinitialize to clear previous state
            appServices.SaveChanges();
            Dictionary<string, List<string>> data = JsonDataAccess.ReadDictionaryFromFile(filePath);

            // Act
            appServices.unpackAll(data);

            // Assert
            Assert.IsNotNull(appServices.listEnseignant);
            Assert.IsNotNull(appServices.listActivite);
            Assert.IsNotNull(appServices.listCote);
            Assert.IsNotNull(appServices.listAppreciation);
            Assert.IsNotNull(appServices.listEtudiant);
        }
    }
}
