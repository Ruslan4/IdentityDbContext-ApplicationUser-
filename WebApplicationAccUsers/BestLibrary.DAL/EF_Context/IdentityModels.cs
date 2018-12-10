using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using BestLib.Models.Entities;
using BestLib.Models.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace BestLibrary.DAL.EF_Context
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet<ClientProfile> ClientProfile { get; set; }
    }
}