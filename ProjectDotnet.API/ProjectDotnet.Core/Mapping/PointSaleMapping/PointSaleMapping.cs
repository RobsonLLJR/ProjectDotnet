using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectDotnet.Core.Models.Domain.PointSale;

namespace ProjectDotnet.Core.Mapping.PointSaleMapping
{
    public class PointSaleMapping : IEntityTypeConfiguration<PointSale>
    {
        public void Configure(EntityTypeBuilder<PointSale> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .IsRequired();

            builder
                .Property(x => x.DateOpen)
                .HasColumnType("date")
                .IsRequired();

            builder
                .Property(x => x.DateClose)
                .HasColumnType("date")
                .IsRequired(false);

            builder
                .Property(x => x.Observation)
                .IsRequired(false);
        }
    }
}
