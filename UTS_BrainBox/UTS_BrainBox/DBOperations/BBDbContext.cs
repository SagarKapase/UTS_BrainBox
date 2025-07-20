using Microsoft.EntityFrameworkCore;
using UTS_BrainBox.Client.Entities;
using UTS_BrainBox.Client.Entities.Admin;

namespace UTS_BrainBox.Client.DBOperations
{
    public class BBDbContext : DbContext
    {
        public BBDbContext(DbContextOptions<BBDbContext> options)
        : base(options)
        {
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=BrainBox;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        public DbSet<AdministrationalDetails> AdministrationalDetails { get; set; }
        public DbSet<CreateQuizzes> AllQuizzes { get; set; }
    }
}
