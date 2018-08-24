using System.Data.Entity;
using JNet.Models;
using Microsoft.AspNet.Identity.EntityFramework;

namespace JNet.Persistences
{
    public class JNetDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Job> Jobs { get; set; }

        public JNetDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static JNetDbContext Create()
        {
            return new JNetDbContext();
        }
    }
}