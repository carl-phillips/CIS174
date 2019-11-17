using CIS174_TestCoreApp.Entities;
using CIS174_TestCoreApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CIS174_TestCoreApp.Authorization
{
    public class IsAdminHandler : AuthorizationHandler<IsAdmin, Person>
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public IsAdminHandler(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        protected override async Task HandleRequirementAsync(
            AuthorizationHandlerContext context,
            IsAdmin requirement,
            Person resource)
        {
            var appUser = await _userManager.GetUserAsync(context.User);
            if(appUser == null)
            {
                return;
            }

            if(resource.CreatedById == appUser.Id)
            {
                context.Succeed(requirement);
            }
        }
    }
}
