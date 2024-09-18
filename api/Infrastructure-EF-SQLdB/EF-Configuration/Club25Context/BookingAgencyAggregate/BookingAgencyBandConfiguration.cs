using Club25_Domain.Aggregates.BookingAgencyAggregate.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration.Club25Context.BookingAgencyAggregate;

public sealed class BookingAgencyBandConfiguration : IEntityTypeConfiguration<BookingAgencyBand>
{
	public void Configure(EntityTypeBuilder<BookingAgencyBand> builder)
	{
		builder.ToTable(nameof(BookingAgencyBand))
		       .HasKey(l => l.Id);

		builder.HasMany(m => m.Bookers)
		       .WithMany(m => m.Bands);

		var columnOrder = 0;

		builder.Property(p => p.Id)
		       .HasColumnOrder(columnOrder++)
		       .HasColumnName(nameof(BookingAgencyBand.Id).ToLower())
		       .UseIdentityColumn();

		builder.ComplexProperty(o => o.PriceMin, navigationBuilder =>
		{
			navigationBuilder.IsRequired();
			navigationBuilder.Property(p => p.Price)
			                 .HasColumnOrder(columnOrder++)
			                 .HasPrecision(10, 2);
			navigationBuilder.Property(p => p.Currency)
			                 .HasColumnOrder(columnOrder++)
			                 .HasConversion<string>();
		});

		builder.ComplexProperty(o => o.PriceMax, navigationBuilder =>
		{
			navigationBuilder.IsRequired();
			navigationBuilder.Property(p => p.Price)
			                 .HasColumnOrder(columnOrder++)
			                 .HasPrecision(10, 2);
			navigationBuilder.Property(p => p.Currency)
			                 .HasColumnOrder(columnOrder++)
			                 .HasConversion<string>();
		});
	}
}