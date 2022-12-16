using Microsoft.AspNetCore.Authorization;
using System;
using System.Threading.Tasks;

namespace Univ_WebSite_Razor_Core_Login5.Authorization
{
    public class HRRequirement : IAuthorizationRequirement
    {
        public HRRequirement(int month)
        {
            Month = month;
        }
        public int Month { get; }
    }

    public class HRRequirementHandler : AuthorizationHandler<HRRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, HRRequirement requirement)
        {
            if (!context.User.HasClaim(x => x.Type == "EmploymentDate"))
            {
                return Task.CompletedTask;
            }
            else
            {
                var empDate = DateTime.Parse(context.User.FindFirst(x => x.Type == "EmploymentDate").Value);
                var period = DateTime.Now - empDate;
                if (period.Days > 30 * requirement.Month)
                    context.Succeed(requirement);

                return Task.CompletedTask;
            }
        }
    }

}
