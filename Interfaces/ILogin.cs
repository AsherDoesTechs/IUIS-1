using IUIS.Models;

namespace IUIS.Interfaces
{
    public interface ILogin
    {
        bool Authenticate(string username, string password, out User? user);
        bool ChangePassword(string userId, string oldPassword, string newPassword);
        void Logout();
    }
}