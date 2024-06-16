namespace Stall_Rental_Management_System.Services.Service_Interfaces
{
    public interface IAuthorizationService
    {
        bool HasPermission(string permission);
    }
}