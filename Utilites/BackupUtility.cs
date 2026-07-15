using System.IO;

namespace IUIS.Utilities
{
    public static class BackupUtility
    {
        public static void CreateBackup(string sourceFolder, string backupFolder)
        {
            if (!Directory.Exists(backupFolder)) Directory.CreateDirectory(backupFolder);
            foreach (string file in Directory.GetFiles(sourceFolder))
            {
                File.Copy(file, Path.Combine(backupFolder, Path.GetFileName(file)), true);
            }
        }
    }
}