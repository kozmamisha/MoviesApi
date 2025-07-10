using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.DependencyInjection;
using MoviesApi.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace MoviesApi.Infrastructure
{
    public class PermissionRequirementsHandler(IServiceScopeFactory serviceScopeFactory) 
        : AuthorizationHandler<PermissionRequirements>
    {
        // injecting repository to take permissions.
        // But as permissionHandler registered as singletone we cannot inject directly in scope service
        // So we inject at first IServiceScopeFactory.
        // After create new scope and through ServiceProvider we get according service (AccountRepository in this case)
        protected override Task HandleRequirementAsync(
            AuthorizationHandlerContext context, 
            PermissionRequirements requirement)
        {
            var userName = context.User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier);

            using var scope = serviceScopeFactory.CreateScope();
            var accountRepository = scope.ServiceProvider.GetService<AccountRepository>();
            var permissions = accountRepository.GetPermissionByUserName(userName.Value);

            if (permissions.Any(x => x.Name == requirement.Permission))
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }



    }
}
