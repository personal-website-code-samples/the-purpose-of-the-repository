using Microsoft.EntityFrameworkCore;

namespace RepositoryPurpose
{
    public sealed class ApplicationContext : DbContext
    {
        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<Airplane> Airplanes { get; set; }
    }
}
