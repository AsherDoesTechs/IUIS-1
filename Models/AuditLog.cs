using System;

namespace IUIS.Models
{
    public class AuditLog
    {
        public string AuditLogId { get; set; } = Guid.NewGuid().ToString("N");
        public DateTime OccurredAt { get; set; } = DateTime.Now;
        public string Username { get; set; } = "System";
        public string Role { get; set; } = "System";
        public string Action { get; set; } = string.Empty;
        public string Module { get; set; } = string.Empty;
        public string RecordId { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string MachineName { get; set; } = Environment.MachineName;
    }
}
