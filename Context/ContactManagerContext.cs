using contact_Manger.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;

namespace contact_Manger.Context

{
    public class ContactManagerContext : DbContext
    {
        public DbSet<Users> users { get; set; }
        public DbSet<Contanct> contacts { get; set;}

        public ContactManagerContext(DbContextOptions<ContactManagerContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>().HasData(new Users { Email = "user123@gmail.com", Name = "user1", Password = "A12345678", Id=1 });

            modelBuilder.Entity<Users>()
                .HasMany(c => c.contacts)
                .WithOne(u => u.user)
                .HasForeignKey(f => f.UserId);

            base.OnModelCreating(modelBuilder);
        }


    }
}
