﻿using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using AWork.Domain.Models;
using System.Security.Claims;
using System.Threading.Tasks;

namespace AWork.Web.Factory
{
    public class CustomClaimsFactory : UserClaimsPrincipalFactory<User>
    {
        public CustomClaimsFactory(UserManager<User> userManager, IOptions<IdentityOptions> optionsAccessor) : base(userManager, optionsAccessor)
        {
        }

        protected override async Task<ClaimsIdentity> GenerateClaimsAsync(User user)
        {
            var identity = await base.GenerateClaimsAsync(user);
            identity.AddClaim(new Claim("firstName", user.FirstName));
            identity.AddClaim(new Claim("lastname", user.LastName));
            identity.AddClaim(new Claim("personType", user.PersonType));

            var roles = await UserManager.GetRolesAsync(user);
            foreach (var role in roles)
            {
                identity.AddClaim(new Claim(ClaimTypes.Role, role));
            }

            return identity;
        }
    }
}
