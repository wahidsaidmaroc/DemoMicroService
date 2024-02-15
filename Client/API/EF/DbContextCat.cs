

using API.Model;
using System.ComponentModel.Design;

namespace API.EF
{
    public class DbContextCat : DbContext
    {
        public DbContextCat(DbContextOptions<DbContextCat> options)
                : base(options) { }

        public DbSet<Client> Clients => Set<Client>();

    }
}
