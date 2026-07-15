using System;
using System.Collections.Generic;
using System.Linq;
using IUIS.Models;
using IUIS.Repositories;

namespace IUIS.Services
{
    public record NotificationItem(string Title, string Message, string Severity);

    public class NotificationService
    {
        private readonly JsonRepository<Borrowing> _borrowings = new("JSON/borrowings.json");
        private readonly JsonRepository<Appointment> _appointments = new("JSON/appointments.json");

        public IReadOnlyList<NotificationItem> ForUser(string userId, string role)
        {
            var notifications = new List<NotificationItem>();
            var today = DateTime.Today;
            foreach (var loan in _borrowings.GetAll().Where(b => b.StudentId == userId && b.ReturnDate == null))
            {
                if (loan.DueDate.Date < today)
                    notifications.Add(new("Library item overdue", $"A borrowed item was due on {loan.DueDate:d}.", "Warning"));
                else if (loan.DueDate.Date == today.AddDays(1))
                    notifications.Add(new("Book due tomorrow", "Please return or renew your borrowed item.", "Info"));
            }
            foreach (var appointment in _appointments.GetAll().Where(a => a.RequesterId == userId && a.Status == "Scheduled" && a.AppointmentTime.Date >= today))
                notifications.Add(new("Upcoming appointment", $"{appointment.Purpose} on {appointment.AppointmentTime:g}.", "Info"));

            if (role == "Admin" && !notifications.Any())
                notifications.Add(new("System ready", "No urgent operational alerts.", "Success"));
            return notifications.OrderBy(n => n.Severity).ToList();
        }
    }
}
