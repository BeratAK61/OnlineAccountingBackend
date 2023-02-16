using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using OnlineAccountingBackend.Domain.AppEntities;

namespace OnlineAccountingBackend.Persistance.Context
{
    public sealed class CompanyDbContext : DbContext
    {
        private readonly string ConnectionString = "";

        public CompanyDbContext(string companyId,Company company = null)
        {
            if (company != null)
            {
                if (company.UserId == "" || company.UserId == null)
                    ConnectionString = $"Data Source={company.ServerName};" +
                    $"InitialCatalog={company.DatabaseName};" +
                    $"Integrated Security=True;" +
                    $"ConnectTimeout=30;" +
                    $"Encrypt=False;" +
                    $"TrusServerCertificate=False;" +
                    $"ApplicationIntent=ReadWrite;" +
                    $"MultiSubnetFailover=False";
                else
                    ConnectionString = $"Data Source={company.ServerName};" +
                    $"InitialCatalog={company.DatabaseName};" +
                    $"User Id={company.UserId};" +
                    $"Password={company.Password};" +
                    $"Integrated Security=True;" +
                    $"ConnectTimeout=30;" +
                    $"Encrypt=False;" +
                    $"TrusServerCertificate=False;" +
                    $"ApplicationIntent=ReadWrite;" +
                    $"MultiSubnetFailover=False";
            }        
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) =>
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AssemblyReference).Assembly);

        public class CombanyDbContextFactory : IDesignTimeDbContextFactory<CompanyDbContext>
        {       
            public CompanyDbContext CreateDbContext(string[] args)
            {
                return new CompanyDbContext("");
            }
        }

    }
}
