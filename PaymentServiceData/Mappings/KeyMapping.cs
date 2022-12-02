using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PaymentServiceBusiness.Models;


namespace PaymentServiceData.Mappings
{
    public class KeyMapping : IEntityTypeConfiguration<Key>
    {
        public void Configure(EntityTypeBuilder<Key> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(t => t.Description)
                .IsRequired()
                .HasColumnType("varchar(1000)");

            builder.ToTable("Key");

        }
    }
}
