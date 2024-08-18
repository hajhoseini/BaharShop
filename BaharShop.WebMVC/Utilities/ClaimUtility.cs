using System.Security.Claims;

namespace BaharShop.WebMVC.Utilities
{
    public static class ClaimUtility
    {
        public static int? GetUserId(ClaimsPrincipal User)
        {
            try
            {
                var claimsIdentity = User.Identity as ClaimsIdentity;

                if (claimsIdentity.FindFirst(ClaimTypes.NameIdentifier) != null)
                {
                    int userId = int.Parse(claimsIdentity.FindFirst(ClaimTypes.NameIdentifier).Value);
                    return userId;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {

                return null;
            }

        }

        public static string GetUserEmail(ClaimsPrincipal User)
        {
            try
            {
                var claimsIdentity = User.Identity as ClaimsIdentity;

                return claimsIdentity.FindFirst(ClaimTypes.Email).Value;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static List<string> GetRoles(ClaimsPrincipal User)
        {
            try
            {
                var claimsIdentity = User.Identity as ClaimsIdentity;
                List<string> rolse = new List<string>();
                foreach (var item in claimsIdentity.Claims.Where(p => p.Type.EndsWith("role")))
                {
                    rolse.Add(item.Value);
                }
                return rolse;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}