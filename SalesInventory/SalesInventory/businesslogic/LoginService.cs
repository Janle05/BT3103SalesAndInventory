using SalesInventory.Repository;

namespace SalesInventory.businesslogic
{
    public class LoginService
    {
        private readonly UserRepository userRepository;

        public LoginService()
        {
            userRepository = new UserRepository();
        }

        public User? Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                return null;

            return userRepository.GetUser(username, password);
        }
    }
}