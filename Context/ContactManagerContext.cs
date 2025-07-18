using contact_Manger.Models;
using Microsoft.EntityFrameworkCore;

namespace contact_Manger.Context

{
    public class ContactManagerContext : DbContext
    {
        public DbSet<Users> users { get; set; }
        public DbSet<Contanct> contacts { get; set;}

        public ContactManagerContext(DbContextOptions<ContactManagerContext> options) : base(options)
        {

        }

        
    }
}
