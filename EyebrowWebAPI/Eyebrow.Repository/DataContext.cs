using Microsoft.EntityFrameworkCore;
using Eyebrow.Repository.Entites;

namespace Eyebrow.Repository
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Announcement> Announcement { get; set; }
    }
}