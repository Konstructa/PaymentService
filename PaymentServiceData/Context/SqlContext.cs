using Microsoft.EntityFrameworkCore;
using PaymentServiceBusiness.Models;
using System;
using System.Collections.Generic;
using System.Text;


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
    }
}
