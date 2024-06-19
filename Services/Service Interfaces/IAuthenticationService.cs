namespace Stall_Rental_Management_System.Services.Service_Interfaces
{
    public interface IAuthenticationService
    {
        bool Login(string phoneNumber, string password);
        void Logout();
        bool IsAuthenticated { get; }
        string CurrentUser { get; }
    }
}