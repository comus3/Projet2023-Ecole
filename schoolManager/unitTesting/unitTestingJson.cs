using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using schoolManager.DAL;

namespace schoolManager.UNITTesting
{
    [TestClass]
    public class JsonDataAccessTests
    {
        [TestMethod]
        public void GenerateBackupName_ReturnsValidFormat()
        {
            // Arrange
            string expectedFormat = @"data_Backup_Of_\d{2}-\d{2}-\d{2}_\d{2}:\d{2}:\d{2}";

            // Act
            string result = JsonDataAccess.GenerateBackupName();

            // Assert
            Assert.IsTrue(System.Text.RegularExpressions.Regex.IsMatch(result, expectedFormat), "Invalid backup name format");
        }

        [TestMethod]
        public void ReadAndWriteDictionaryToFile()
        {
            // Arrange
            string testFilePath = "testFile.txt";
            Dictionary<string, List<string>> originalDictionary = new Dictionary<string, List<string>>
            {
                { "Key1", new List<string> { "Value11", "Value12", "Value13" } },
                { "Key2", new List<string> { "Value21", "Value22" } },
                { "Key3", new List<string> { "Value31", "Value32", "Value33", "Value34" } }
            };

            // Act
            JsonDataAccess.WriteDictionaryToFile(originalDictionary, testFilePath);
            Dictionary<string, List<string>> resultDictionary = JsonDataAccess.ReadDictionaryFromFile(testFilePath);

            // Assert
            CollectionAssert.AreEqual(originalDictionary, resultDictionary, "Read and write dictionary mismatch");
        }
    }
}
