using Stall_Rental_Management_System.Enums;

namespace Stall_Rental_Management_System.Services.Service_Interfaces
{
    public interface IAuthenticationService
    {
        bool Login(string phoneNumber, string password, UserType userType);
        void Logout();
        bool IsAuthenticated { get; }
        string CurrentUser { get; }
    }
}