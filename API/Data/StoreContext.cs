using API.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class StoreContext : IdentityDbContext<User>
    {
        public StoreContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            this.SeedUsers(builder);

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Name = "Member", NormalizedName = "MEMBER" },
                new IdentityRole { Name = "Admin", NormalizedName = "ADMIN" }
            );
        }

        private void SeedUsers(ModelBuilder builder)
        {
            var hasher = new PasswordHasher<User>();
            builder.Entity<User>().HasData(
                new User
                {
                    UserName = "admin",
                    Email = "admin@test.com",
                    NormalizedUserName = "ADMIN",
                    PasswordHash = hasher.HashPassword(null, "temporarypass"),

                },
                new User
                {
                    UserName = "user",
                    Email = "user@test.com",
                    NormalizedUserName = "MEMBER",
                    PasswordHash = hasher.HashPassword(null, "temporarypass"),
                }
            );
        }
    }
}