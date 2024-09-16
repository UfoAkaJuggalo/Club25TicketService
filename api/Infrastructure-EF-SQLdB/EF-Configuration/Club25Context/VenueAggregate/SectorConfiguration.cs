using Club25_Domain.Aggregates.VenueAggregate.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration.Club25Context.VenueAggregate;

public sealed class SectorConfiguration : IEntityTypeConfiguration<Sector>
{
	public void Configure(EntityTypeBuilder<Sector> builder)
	{
		builder.ToTable(nameof(Sector))
		       .HasKey(k => k.Id);

		builder.HasMany(m => m.Seats)
		       .WithOne(s => s.Sector)
		       .HasForeignKey(s => s.SectorId);

		builder.HasOne(o => o.Plan)
		       .WithOne()
		       .HasForeignKey<Sector>(f => f.LinkId)
		       .IsRequired(false);

		var columnOrder = 0;

		builder.Property(p => p.Id)
		       .HasColumnOrder(columnOrder++)
		       .HasColumnName(nameof(Sector.Id).ToLower())
		       .UseIdentityColumn();

		builder.Property(p => p.Name)
		       .HasColumnOrder(columnOrder++)
		       .HasMaxLength(25)
		       .HasColumnName(nameof(Sector.Name).ToLower());

		builder.Property(p => p.Capacity)
		       .HasColumnOrder(columnOrder++)
		       .HasColumnName(nameof(Sector.Capacity).ToLower());

		builder.Property(p => p.SectorType)
		       .HasColumnName(nameof(Sector.SectorType).ToLower())
		       .HasColumnOrder(columnOrder++)
		       .HasConversion<string>();
	}
}