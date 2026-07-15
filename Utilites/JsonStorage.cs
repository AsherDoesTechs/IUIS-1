using System.IO;
using System.Text.Json;
using IUIS.Interfaces;
namespace IUIS.Utilities
{
    public class JsonStorage : IJsonStorage
    {
        private static readonly JsonSerializerOptions _options = new()
        {
            WriteIndented = true,
            PropertyNameCaseInsensitive = true
        };

        public T LoadData<T>(string filePath)
        {
            if (string.IsNullOrWhiteSpace(filePath) || !Exists(filePath))
            {
                return default!;
            }

            string json = File.ReadAllText(filePath);
            if (string.IsNullOrWhiteSpace(json))
            {
                return default!;
            }

            return JsonSerializer.Deserialize<T>(json, _options)!;
        }

        public void SaveData<T>(string filePath, T data)
        {
            if (string.IsNullOrWhiteSpace(filePath))
            {
                return;
            }

            string? directory = Path.GetDirectoryName(filePath);
            if (!string.IsNullOrWhiteSpace(directory))
            {
                Directory.CreateDirectory(directory);
            }

            string json = JsonSerializer.Serialize(data, _options);
            File.WriteAllText(filePath, json);
        }

        public bool Exists(string filePath) => File.Exists(filePath);

        public static T Load<T>(string filePath) => new JsonStorage().LoadData<T>(filePath);

        public static void Save<T>(string filePath, T data) => new JsonStorage().SaveData(filePath, data);
    }
}