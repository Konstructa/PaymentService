using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PaymentServiceBusiness.Models;


namespace PaymentServiceData.Mappings
{
    public class PayerMapping : IEntityTypeConfiguration<Payer>
    {
        public void Configure(EntityTypeBuilder<Payer> builder)
        {
            builder.HasKey(x => x.Key);

            builder.Property(t => t.Name)
                .IsRequired()
                .HasColumnType("varchar(1000)");

            builder.ToTable("Payer");
        }
    }
}
