using Club25_Domain.Aggregates.VenueAggregate.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration.Club25Context.VenueAggregate;

public sealed class SeatConfiguration : IEntityTypeConfiguration<Seat>
{
	public void Configure(EntityTypeBuilder<Seat> builder)
	{
		builder.ToTable(nameof(Seat))
		       .HasKey(x => x.Id);

		var columnOrder = 0;

		builder.Property(p => p.Id)
		       .HasColumnOrder(columnOrder++)
		       .HasColumnName(nameof(Seat.Id).ToLower())
		       .UseIdentityColumn();

		builder.Property(p => p.Number)
		       .HasColumnOrder(columnOrder++)
		       .HasColumnName(nameof(Seat.Number).ToLower());

		builder.Property(p => p.PlanX)
		       .HasColumnOrder(columnOrder++)
		       .HasColumnName(nameof(Seat.PlanX).ToLower());

		builder.Property(p => p.PlanY)
		       .HasColumnOrder(columnOrder++)
		       .HasColumnName(nameof(Seat.PlanY).ToLower());

		builder.Property(p => p.Size)
		       .HasColumnOrder(columnOrder++)
		       .HasColumnName(nameof(Seat.Size).ToLower());
	}
}