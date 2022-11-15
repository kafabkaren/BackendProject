using kafagymstoreApi.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace kafagymstoreApi.Contexts
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<CustomerEntity> Customers { get; set; }
    }
}
