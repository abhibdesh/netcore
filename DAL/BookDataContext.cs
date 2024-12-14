using CoreTrainingDayTwo08122024.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreTrainingDayTwo08122024.DAL
{
    public class BookDataContext : DbContext
    {
        public BookDataContext(DbContextOptions options) : base(options) { 
        
            Database.EnsureCreated();
        }
        public DbSet<Book>  Books { get; set; }
    }
}
