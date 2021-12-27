using LoginRegistrationApi.Model;

namespace LoginRegistrationApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        public DbSet<Login>Logins { get; set; }
        public DbSet<Registration>Registrations { get; set; }
    }
}
