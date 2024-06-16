using Stall_Rental_Management_System.Services.Service_Interfaces;

namespace Stall_Rental_Management_System.Services
{
    public class AuthorizationService : IAuthorizationService
    {
        private readonly IAuthenticationService _authenticationService;

        public AuthorizationService(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }

        public bool HasPermission(string permission)
        {
            // Implement actual authorization logic
            if (!_authenticationService.IsAuthenticated) return false;

            // Example: Admin has all permissions
            return _authenticationService.CurrentUser == "admin";
        }
    }
}