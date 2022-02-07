using Microsoft.EntityFrameworkCore;
using JustWatch.Models;
    
namespace JustWatch.Data
{
    public class JustWatchDBContext : DbContext
    {
        public JustWatchDBContext(DbContextOptions<JustWatchDBContext> options) : base(options)
        {

        }

        public DbSet<User> Users{ get; set; }
    }
}
