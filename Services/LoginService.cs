using IUIS.Interfaces;
using IUIS.Models;
using IUIS.Repositories;
using IUIS.Utilities;

namespace IUIS.Services
{
    public class LoginService : ILogin
    {
        private readonly UserRepository _userRepository;

        public LoginService()
        {
            _userRepository = new UserRepository();
        }

        public bool Authenticate(string username, string password, out User? user)
        {
            user = null;
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return false;
            }

            var foundUser = _userRepository.GetByUsername(username);

            if (foundUser != null && foundUser.IsEnabled && PasswordHasher.VerifyPassword(password, foundUser.PasswordHash))
            {
                user = foundUser;
                foundUser.LastLogin = DateTime.Now;
                _userRepository.Update(foundUser);
                return true;
            }

            return false;
        }

        public bool ChangePassword(string userId, string oldPassword, string newPassword)
        {
            return false;
        }

        public void Logout()
        {
            SessionManager.ClearSession();
        }
    }
}