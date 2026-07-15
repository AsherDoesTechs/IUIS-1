using System;
using System.Collections.Generic;
using System.IO;
using IUIS.Models;
using IUIS.Utilities;

namespace IUIS.Services
{
    public static class AuditService
    {
        private static readonly string FilePath = Path.Combine(AppContext.BaseDirectory, "Data", "audit_logs.json");

        public static void Record(string action, string module, string recordId, string description)
        {
            var storage = new JsonStorage();
            var logs = storage.LoadData<List<AuditLog>>(FilePath) ?? new List<AuditLog>();
            var user = SessionManager.CurrentUser;
            logs.Add(new AuditLog
            {
                Username = user?.Username ?? "System",
                Role = user?.Role ?? "System",
                Action = action,
                Module = module,
                RecordId = recordId,
                Description = description
            });
            storage.SaveData(FilePath, logs);
        }
    }
}
