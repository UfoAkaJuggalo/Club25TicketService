using Club25_Domain.Aggregates.TicketPoolAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration.Club25Context.TicketPoolAggregate;

public sealed class DiscountConfiguration : IEntityTypeConfiguration<Discount>
{
	public void Configure(EntityTypeBuilder<Discount> builder)
	{
		builder.ToTable(nameof(Discount))
		       .HasKey(k => k.Id);

		builder.HasMany(m => m.Names)
		       .WithOne(m => m.Discount);

		builder.HasMany(m => m.DiscountDescriptions)
		       .WithOne(m => m.Discount);

		var columnOrder = 0;

		builder.Property(p => p.Id)
		       .HasColumnName(nameof(Discount.Id).ToLower())
		       .HasColumnOrder(columnOrder++)
		       .UseIdentityColumn();
		builder.Property(p => p.Multipler)
		       .HasColumnName(nameof(Discount.Multipler).ToLower())
		       .HasColumnOrder(columnOrder)
		       .HasPrecision(4, 4);
	}
}