namespace IUIS.Interfaces
{
    public interface IJsonStorage
    {
        T LoadData<T>(string filePath);
        void SaveData<T>(string filePath, T data);
        bool Exists(string filePath);
    }
}