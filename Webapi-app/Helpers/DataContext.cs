using Microsoft.EntityFrameworkCore;
using Webapi_app.Entities;

namespace Webapi_app.Helpers
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
