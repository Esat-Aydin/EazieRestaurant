using Duende.IdentityServer.Models;

namespace Eazie.Services.Identity
{
    public static class SD
    {
        public const string Admin = "Admin";
        public const string Customer = "Customer";

        public static IEnumerable<IdentityResource> IdentityResources =>
            new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Email(),
                new IdentityResources.Profile()
            };

        public static IEnumerable<ApiScope> ApiScopes=>
            new List<ApiScope>
            {
                new ApiScope("eazie.api", "Eazie Server")
            };
    }
}
