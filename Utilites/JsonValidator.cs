using System.IO;

namespace IUIS.Utilities
{
    public static class JsonValidator
    {
        public static bool IsFileValid(string filePath)
        {
            return File.Exists(filePath) && new FileInfo(filePath).Length > 0;
        }
    }
}