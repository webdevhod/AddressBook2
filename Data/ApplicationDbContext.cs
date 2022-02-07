using Microsoft.EntityFrameworkCore;
using AddressBook2.Models;

namespace AddressBook2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<AddressBook2.Models.Contact> Contact { get; set; }
    }
}