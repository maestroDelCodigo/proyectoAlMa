using ApiEjemplo.Controllers;
using Microsoft.EntityFrameworkCore;

namespace ApiEjemplo
{
    public class StravaContext : DbContext
    {
        public StravaContext(DbContextOptions<StravaContext> options) : base(options)
        {
        }

        public DbSet<Activity> Activities { get; set; }
    }
}