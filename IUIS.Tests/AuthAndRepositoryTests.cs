using System.Linq;
using IUIS.Models;
using IUIS.Repositories;
using IUIS.Services;
using IUIS.Utilities;

namespace IUIS.Tests;

public class AuthAndRepositoryTests
{
    [Fact]
    public void Authenticate_WithValidCredentials_ReturnsUser()
    {
        var loginService = new LoginService();

        var authenticated = loginService.Authenticate("admin", "password", out var user);

        Assert.True(authenticated);
        Assert.NotNull(user);
        Assert.Equal("Admin", user!.Role);
    }

    [Fact]
    public void Authenticate_WithInvalidCredentials_ReturnsFalse()
    {
        var loginService = new LoginService();

        var authenticated = loginService.Authenticate("admin", "wrong-password", out var user);

        Assert.False(authenticated);
        Assert.Null(user);
    }

    [Fact]
    public void SeedData_ContainsSampleRecords_ForAdminTeacherAndStudentRoles()
    {
        var students = new JsonRepository<Student>("Data/students.json").GetAll().ToList();
        var teachers = new JsonRepository<Teacher>("Data/teachers.json").GetAll().ToList();
        var subjects = new JsonRepository<Subject>("Data/subjects.json").GetAll().ToList();

        Assert.NotEmpty(students);
        Assert.NotEmpty(teachers);
        Assert.NotEmpty(subjects);
        Assert.Contains(students, student => student.FirstName == "Mina");
        Assert.Contains(teachers, teacher => teacher.FirstName == "Rosa");
        Assert.Contains(subjects, subject => subject.SubjectCode == "CS101");
    }

    [Fact]
    public void JsonRepository_CanPersistAndRetrieveItems()
    {
        var tempPath = Path.Combine(Path.GetTempPath(), $"iuis-tests-{Guid.NewGuid():N}.json");
        try
        {
            var repo = new JsonRepository<User>(tempPath);
            var user = new User { Username = "tester", PasswordHash = PasswordHasher.HashPassword("secret"), Role = "Student" };

            repo.Add(user);
            var saved = repo.GetById(user.UserId);

            Assert.NotNull(saved);
            Assert.Equal("tester", saved!.Username);
        }
        finally
        {
            if (File.Exists(tempPath))
            {
                File.Delete(tempPath);
            }
        }
    }
}
