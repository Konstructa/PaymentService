using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PaymentServiceBusiness.Models;


namespace PaymentServiceData.Mappings
{
    public class TransactionMapping : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(t => t.TransactionDate)
                .IsRequired()
                .HasColumnType("date");

            builder.HasOne(p => p.Receiver)
                .WithMany(p => p.Transactions)
                .IsRequired();

            builder.HasOne(p => p.Payer)
                .WithMany(p => p.Transactions)
                .IsRequired();

            builder.ToTable("Transactions");
        }
    }
}
