using Microsoft.EntityFrameworkCore;

namespace School.Models
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-H9U96TE\SQLEXPRESS;Initial Catalog=StdDb;Integrated Security=true");
        }
    }
}
