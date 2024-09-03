using TechServe.Components.Helpers;

namespace TechServe.Components.Services
{
    public class AuthService
    {
        public bool VerifyPassword(string enteredPassword, string storedHash)
        {
            var hashOfEnteredPassword = PasswordHelper.HashPassword(enteredPassword);
            return hashOfEnteredPassword == storedHash;
        }
    }
}
