using Club25_Domain.Aggregates.TicketPoolAggregate;
using Club25_Domain.Common.VObase;
using Infrastructure_EF_SQLdB.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure_EF_SQLdB.EF_Configuration.TicketPoolAggregate;

public sealed class TicketPoolConfiguration : IEntityTypeConfiguration<TicketPool>
{
	public void Configure(EntityTypeBuilder<TicketPool> builder)
	{
		builder.ToTable(nameof(TicketPool))
		       .HasKey(k => k.Id);

		builder.HasMany(m => m.AvailableDiscounts)
		       .WithMany();

		builder.HasMany(m => m.Tickets)
		       .WithOne(m => m.TicketPool)
		       .HasForeignKey(m => m.TicketPoolId);

		builder.HasMany(m => m.TicketAgents)
		       .WithMany(m => m.TicketPools);

		builder.HasMany(m => m.Descriptions)
		       .WithOne(m => m.TicketPool)
		       .HasForeignKey(m => m.TicketPoolId);

		var columnOrder = 0;

		builder.Property(e => e.Id)
		       .HasColumnOrder(columnOrder++)
		       .HasColumnName(nameof(TicketPool.Id).ToLower())
		       .UseIdentityColumn();

		builder.Property(e => e.Name)
		       .HasColumnName(nameof(TicketPool.Name).ToLower())
		       .HasColumnOrder(columnOrder++);

		builder.Property(e => e.DateStart)
		       .HasColumnName(nameof(TicketPool.DateStart).ToLower())
		       .HasColumnOrder(columnOrder++)
		       .HasConversion(new DateTimeToStringConverter());

		builder.Property(p => p.Profit)
		       .HasColumnOrder(columnOrder++)
		       .HasColumnName(nameof(TicketPool.Profit).ToLower())
		       .HasPrecision(10, 2);

		builder.Property(p => p.EventStart)
		       .HasColumnName(nameof(TicketPool.EventStart).ToLower())
		       .HasColumnOrder(columnOrder++)
		       .HasConversion(new DateTimeToStringConverter());

		builder.Property(p => p.EventEnd)
		       .HasColumnOrder(columnOrder++)
		       .HasColumnName(nameof(TicketPool.EventEnd).ToLower())
		       .HasConversion(new DateTimeToStringConverter());

		builder.Property(p => p.TicketType)
		       .HasColumnOrder(columnOrder++)
		       .HasColumnName(nameof(TicketPool.TicketType).ToLower())
		       .HasConversion<string>();

		builder.Property(p => p.MediaTypes)
		       .HasColumnOrder(columnOrder)
		       .HasColumnName(nameof(TicketPool.MediaTypes).ToLower())
		       .HasConversion(Converters.TicketMediaTypeConverter);

		builder.OwnsOne(o => o.TicketPrice, navigationBuilder =>
		{
			navigationBuilder.Property(p => p.Price)
			                 .HasColumnName(nameof(PriceVO.Price).ToLower())
			                 .HasPrecision(10, 2);
			navigationBuilder.Property(p => p.Currency)
			                 .HasColumnName(nameof(PriceVO.Currency).ToLower())
			                 .HasConversion<string>();
		});
	}
}