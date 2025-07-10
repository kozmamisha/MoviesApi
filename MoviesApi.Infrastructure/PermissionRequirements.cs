using Microsoft.AspNetCore.Authorization;

namespace MoviesApi.Infrastructure
{
    public class PermissionRequirements : IAuthorizationRequirement
    {
        public string Permission { get; }
        public PermissionRequirements(string permission)
        {
            Permission = permission;
        }
    }
}
