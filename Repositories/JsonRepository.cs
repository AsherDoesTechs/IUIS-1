using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using IUIS.Interfaces;
using IUIS.Services;
using IUIS.Utilities;

namespace IUIS.Repositories
{
    public class JsonRepository<T> : IRepository<T> where T : class
    {
        private readonly string _filePath;
        private readonly JsonStorage _storage;
        private readonly List<T> _items;

        public JsonRepository(string filePath)
        {
            _storage = new JsonStorage();
            _filePath = ResolveFilePath(filePath);
            _items = _storage.LoadData<List<T>>(_filePath) ?? new List<T>();

            if (!_storage.Exists(_filePath))
            {
                _storage.SaveData(_filePath, _items);
            }
        }

        public IEnumerable<T> GetAll() => _items;

        public T GetById(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return null!;
            }

            var property = typeof(T).GetProperty("Id") ?? typeof(T).GetProperty("UserId");
            return _items.FirstOrDefault(x => property?.GetValue(x)?.ToString() == id);
        }

        public void Add(T entity)
        {
            _items.Add(entity);
            Save();
            Publish("Added", entity);
        }

        public void Update(T entity)
        {
            var property = typeof(T).GetProperty("Id") ?? typeof(T).GetProperty("UserId");
            if (property == null)
            {
                return;
            }

            string? key = property.GetValue(entity)?.ToString();
            if (string.IsNullOrWhiteSpace(key))
            {
                return;
            }

            int index = _items.FindIndex(x => property.GetValue(x)?.ToString() == key);
            if (index >= 0)
            {
                _items[index] = entity;
            }
            else
            {
                _items.Add(entity);
            }

            Save();
            Publish("Updated", entity);
        }

        public void Delete(string id)
        {
            var item = GetById(id);
            if (item != null)
            {
                _items.Remove(item);
            }

            Save();
            RepositoryEvents.Publish(typeof(T).Name, "Deleted", id);
            AuditService.Record("Deleted", typeof(T).Name, id, $"Deleted {typeof(T).Name} record.");
        }

        public void Save() => _storage.SaveData(_filePath, _items);

        private static void Publish(string action, T entity)
        {
            var property = typeof(T).GetProperty("Id") ?? typeof(T).GetProperty("UserId") ?? typeof(T).GetProperty($"{typeof(T).Name}Id");
            string recordId = property?.GetValue(entity)?.ToString() ?? string.Empty;
            RepositoryEvents.Publish(typeof(T).Name, action, recordId);
            AuditService.Record(action, typeof(T).Name, recordId, $"{action} {typeof(T).Name} record.");
        }

        private static string ResolveFilePath(string filePath)
        {
            if (Path.IsPathRooted(filePath))
            {
                return filePath;
            }

            var candidates = new List<string>
            {
                Path.GetFullPath(filePath),
                Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, filePath)),
                Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), filePath))
            };

            var repoRoot = FindRepositoryRoot();
            if (!string.IsNullOrWhiteSpace(repoRoot))
            {
                candidates.Add(Path.GetFullPath(Path.Combine(repoRoot, filePath)));
            }

            foreach (var candidate in candidates.Distinct(StringComparer.OrdinalIgnoreCase))
            {
                if (File.Exists(candidate))
                {
                    return candidate;
                }
            }

            return Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, filePath));
        }

        private static string? FindRepositoryRoot()
        {
            var directory = new DirectoryInfo(AppContext.BaseDirectory);
            while (directory != null)
            {
                if (File.Exists(Path.Combine(directory.FullName, "IUIS.slnx")) || File.Exists(Path.Combine(directory.FullName, "IUIS.csproj")))
                {
                    return directory.FullName;
                }

                directory = directory.Parent;
            }

            return null;
        }
    }
}
