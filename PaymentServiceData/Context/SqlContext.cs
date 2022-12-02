using Microsoft.EntityFrameworkCore;
using PaymentServiceBusiness.Models;


namespace PaymentServiceData.Context
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Payer> Payers { get; set; }
        public DbSet<Receiver> Receivers { get; set; }
        public DbSet<Key> Keys { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SqlContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
