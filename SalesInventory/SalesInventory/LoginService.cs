using SalesInventory.businesslogic;
using SalesInventory.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace SalesInventory
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
            if (string.IsNullOrWhiteSpace(username))
            {
                return null;
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                return null;
            }

            return userRepository.GetUser(username, password);
        }
    }
}