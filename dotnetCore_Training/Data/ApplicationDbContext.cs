using dotnetCore_Training.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnetCore_Training.Data
{
    public class ApplicationDbContext : DbContext //efcore
    {
        //constructor is called when object is created/initialized
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        //DB9
        public DbSet<Student> Students { get; set; }


    }
}
