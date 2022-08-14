using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using PI2022.Models;

namespace PI2022.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<PI2022.Models.Employees>? Employees { get; set; }
        public DbSet<PI2022.Models.Equipment>? Equipment { get; set; }
        public DbSet<PI2022.Models.Offers>? Offers { get; set; }
    }
}