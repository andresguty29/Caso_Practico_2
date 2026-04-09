using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Data.Entity;

namespace CasoPractico1.Models
{
    public class ApplicationUser : IdentityUser
    {
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext() : base("Contexto", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }

    public static class IdentitySeeder
    {
        public static void EnsureRoles()
        {
            using (var context = new ApplicationDbContext())
            {
                var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

                if (!roleManager.RoleExists("Administrador"))
                {
                    roleManager.Create(new IdentityRole("Administrador"));
                }

                if (!roleManager.RoleExists("Cliente"))
                {
                    roleManager.Create(new IdentityRole("Cliente"));
                }
            }
        }
    }
}
