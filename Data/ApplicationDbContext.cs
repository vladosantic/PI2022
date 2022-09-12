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
        public DbSet<PI2022.Models.Jobs>? Jobs { get; set; }
        public DbSet<PI2022.Models.Schedule>? Schedule { get; set; }
        public DbSet<PI2022.Models.Bidding>? Bidding { get; set; }
        public DbSet<PI2022.Models.References>? References { get; set; }
        public DbSet<PI2022.Models.Dashboard>? Dashboard { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole {
                Id = "1", Name = "administrator", NormalizedName = "ADMINISTRATOR".ToUpper() });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole {
                Id = "2", Name = "vlasnik", NormalizedName = "VLASNIK".ToUpper() });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole {
                Id = "3", Name = "poslodavac", NormalizedName = "POSLODAVAC".ToUpper() });
            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole {
                Id = "4", Name = "zaposlenik", NormalizedName = "ZAPOSLENIK".ToUpper() });

            var hasher = new PasswordHasher<IdentityUser>();

            modelBuilder.Entity<IdentityUser>().HasData(
                new IdentityUser
                {
                    Id = "1", 
                    UserName = "admin",
                    NormalizedUserName = "ADMIN",
                    PasswordHash = hasher.HashPassword(null, "Sifra123."),
                    Email = "admin@firma.ba",
                    NormalizedEmail = "ADMIN@FIRMA.BA",
                    EmailConfirmed = true
                }
            );

            modelBuilder.Entity<IdentityUser>().HasData(
                new IdentityUser
                {
                    Id = "5",
                    UserName = "test",
                    NormalizedUserName = "TEST",
                    PasswordHash = hasher.HashPassword(null, "Sifra.123"),
                    Email = "test@firma.ba",
                    NormalizedEmail = "TEST@FIRMA.BA"
                }
            );

            modelBuilder.Entity<IdentityUser>().HasData(
                new IdentityUser
                {
                    Id = "2",
                    UserName = "vlasnik",
                    NormalizedUserName = "VLASNIK",
                    PasswordHash = hasher.HashPassword(null, "Sifra123."),
                    Email = "vlasnik@firma.ba",
                    NormalizedEmail = "VLASNIK@FIRMA.BA",
                    EmailConfirmed = true
                }
            );

            modelBuilder.Entity<IdentityUser>().HasData(
                new IdentityUser
                {
                    Id = "3",
                    UserName = "poslodavac",
                    NormalizedUserName = "POSLODAVAC",
                    PasswordHash = hasher.HashPassword(null, "Sifra123."),
                    Email = "poslodavac@firma.ba",
                    NormalizedEmail = "POSLODAVAC@FIRMA.BA",
                    EmailConfirmed = true
                }
            );

            modelBuilder.Entity<IdentityUser>().HasData(
                new IdentityUser
                {
                    Id = "4",
                    UserName = "zaposlenik",
                    NormalizedUserName = "ZAPOSLENIK",
                    PasswordHash = hasher.HashPassword(null, "Sifra123."),
                    Email = "zaposlenik@firma.ba",
                    NormalizedEmail = "ZASPOLENIK@FIRMA.BA",
                    EmailConfirmed = true
                }
            );

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "1",
                    UserId = "1"
                }
            );

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "2",
                    UserId = "1"
                }
            );

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "3",
                    UserId = "1"
                }
            );

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "4",
                    UserId = "1"
                }
            );

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "2",
                    UserId = "2"
                }
            );

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "3",
                    UserId = "2"
                }
            );

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "4",
                    UserId = "2"
                }
            );

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "3",
                    UserId = "3"
                }
            );

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "4",
                    UserId = "3"
                }
            );

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "4",
                    UserId = "4"
                }
            );


        }
    }
}