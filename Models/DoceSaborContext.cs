using Microsoft.EntityFrameworkCore;

namespace DoceSabor.Models
{
    public class DoceSaborContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("Server=localhost;DataBase=DoceSabor;Uid=root;Pwd=;");
        }
        public DbSet<Feedback> Feedbacks {get;set;}
        public DbSet<Admin> Admins {get;set;}
    }
}