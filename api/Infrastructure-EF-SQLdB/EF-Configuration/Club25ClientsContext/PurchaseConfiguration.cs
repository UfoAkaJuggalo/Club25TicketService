using Club25_Domain.Aggregates.ClientAggregate.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration.Club25ClientsContext;

public sealed class PurchaseConfiguration : IEntityTypeConfiguration<Purchase>
{
	public void Configure(EntityTypeBuilder<Purchase> builder)
	{
		builder.ToTable(nameof(Purchase))
		       .HasKey(k => k.Id);

		var columnOrder = 0;

		builder.Property(p => p.Id)
		       .HasColumnName(nameof(Purchase.Id).ToLower())
		       .IsRequired()
		       .HasColumnOrder(columnOrder++)
		       .HasConversion<Guid>()
		       .ValueGeneratedOnAdd();

		builder.Property(p => p.PurchaseStatus)
		       .HasColumnName(nameof(Purchase.PurchaseStatus).ToLower())
		       .HasColumnOrder(columnOrder++)
		       .HasConversion<string>();

		builder.Property(p => p.PurchaseDate)
		       .HasColumnName(nameof(Purchase.PurchaseDate).ToLower())
		       .HasColumnOrder(columnOrder++)
		       .HasConversion<DateTime>();

		builder.Property(p => p.TicketId)
		       .HasColumnName(nameof(Purchase.TicketId).ToLower())
		       .HasColumnOrder(columnOrder)
		       .HasConversion<Guid>();
	}
}