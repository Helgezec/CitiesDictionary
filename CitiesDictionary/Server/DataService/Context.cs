using CitiesDictionary.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace CitiesDictionary.Server.DataService
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options) { }

        public DbSet<City> Cities { get; set; }

    }
}
