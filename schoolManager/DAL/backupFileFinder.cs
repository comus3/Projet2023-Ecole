using System;
using System.Collections.Generic;
using System.IO;
namespace schoolManager.DAL;

public class BackupFileFinder
{
    public static List<string> FindBackupFileNames(string backupFolder)
    {
        List<string> backupFileNames = new List<string>();

        try
        {
            // Check if the directory exists
            if (Directory.Exists(backupFolder))
            {
                // Get all files in the directory with the specified prefix
                string[] files = Directory.GetFiles(backupFolder, "data_Backup_Of_*");

                // Add the matching file names to the list
                backupFileNames.AddRange(files);
            }
            else
            {
                Console.WriteLine("The specified directory does not exist.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }

        return backupFileNames;
    }
}
