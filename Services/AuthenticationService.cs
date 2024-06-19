using System;
using Stall_Rental_Management_System.Services.Service_Interfaces;

namespace Stall_Rental_Management_System.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        public AuthenticationService()
        {
            Logout();
        }
        
        public bool Login(string phoneNumber, string password)
        {
            // Implement actual authentication logic
            if (phoneNumber == "admin" && password == "password")
            {
                IsAuthenticated = true;
                CurrentUser = phoneNumber;
                return true;
            }
            IsAuthenticated = false;
            return false;
        }

        public void Logout()
        {
            IsAuthenticated = false;
            CurrentUser = null;
        }

        public bool IsAuthenticated { get; private set; }

        public string CurrentUser { get; private set; }
    }
}