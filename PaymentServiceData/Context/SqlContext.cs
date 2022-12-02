using Microsoft.EntityFrameworkCore;
using PaymentServiceBusiness.Models;
using PaymentServiceData.Mappings;

namespace PaymentServiceData.Context
{
    public class SqlContext : DbContext
    {
        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {
        }

        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Payer> Payers { get; set; }
        public DbSet<Receiver> Receivers { get; set; }
        public DbSet<Key> Keys { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new KeyMapping());
            modelBuilder.ApplyConfiguration(new PayerMapping());
            modelBuilder.ApplyConfiguration(new ReceiverMapping());
            modelBuilder.ApplyConfiguration(new TransactionMapping());
        }
    }
}
