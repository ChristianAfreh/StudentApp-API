using System;
using System.Security.Claims;
using System.Linq;

namespace SIS.Shared.Helpers
{
    public class GlobalFunction
    {
        public static string GetAcadYearString(int acadYear)
        {
            return acadYear - 1 + "/" + acadYear;
        }

        public static string GetUsername(ClaimsPrincipal user)
        {
            var username = user.FindFirst("Name") == null ? "" : user.FindFirst("Name").Value;
            return username;
        }
    }
}
