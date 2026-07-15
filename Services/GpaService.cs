using System;
using System.Collections.Generic;
using System.Linq;
using IUIS.Models;
using IUIS.Repositories;

namespace IUIS.Services
{
    public class GpaService
    {
        private readonly JsonRepository<Enrollment> _enrollments = new("JSON/enrollments.json");
        private readonly JsonRepository<Grade> _grades = new("JSON/grades.json");
        private readonly JsonRepository<Subject> _subjects = new("Data/subjects.json");

        public decimal Calculate(string studentId)
        {
            var enrollments = _enrollments.GetAll().Where(e => e.StudentId == studentId).ToList();
            var subjects = _subjects.GetAll().ToDictionary(s => s.SubjectId, s => Math.Max(1, s.Units));
            var completed = _grades.GetAll().Join(enrollments, g => g.EnrollmentId, e => e.EnrollmentId,
                (grade, enrollment) => new { grade.Score, Units = subjects.GetValueOrDefault(enrollment.SubjectId, 1) }).ToList();

            if (completed.Count == 0) return 0m;
            decimal units = completed.Sum(x => x.Units);
            return units == 0 ? 0m : Math.Round(completed.Sum(x => GradePoint(x.Score) * x.Units) / units, 2);
        }

        private static decimal GradePoint(decimal score) => score switch
        {
            >= 97 => 4.00m, >= 93 => 3.75m, >= 89 => 3.50m, >= 85 => 3.25m,
            >= 81 => 3.00m, >= 77 => 2.75m, >= 73 => 2.50m, >= 69 => 2.25m,
            >= 65 => 2.00m, >= 60 => 1.00m, _ => 0m
        };
    }
}
