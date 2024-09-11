using Club25_Domain.Aggregates.BandAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration.BandAggregate;

public sealed class BandConfiguration : IEntityTypeConfiguration<Band>
{
	public void Configure(EntityTypeBuilder<Band> builder)
	{
		builder.ToTable(nameof(Band))
		       .HasKey(k => k.Id);

		builder.HasMany(m => m.Members)
		       .WithMany(m => m.Bands);

		builder.HasMany(m => m.Descriptions)
		       .WithOne(o => o.Band)
		       .HasForeignKey(k => k.BandId)
		       .OnDelete(DeleteBehavior.ClientSetNull);

		builder.HasMany(m => m.Links)
		       .WithOne();

		builder.HasMany(m => m.Tags)
		       .WithMany(m => m.Bands);

		builder.HasMany(m => m.Bookers)
		       .WithOne(o => o.Band)
		       .HasForeignKey(k => k.BandId)
		       .IsRequired()
		       .OnDelete(DeleteBehavior.ClientSetNull);

		builder.HasMany(m => m.LineupEntries)
		       .WithOne(o => o.Band)
		       .HasForeignKey(k => k.BandId)
		       .IsRequired()
		       .OnDelete(DeleteBehavior.ClientSetNull);

		var columnOrder = 0;

		builder.Property(p => p.Id)
		       .HasColumnOrder(columnOrder++)
		       .HasColumnName(nameof(Band.Id).ToLower())
		       .UseIdentityColumn();

		builder.Property(p => p.Name)
		       .IsRequired()
		       .HasColumnOrder(columnOrder++)
		       .HasMaxLength(100)
		       .HasColumnName(nameof(Band.Name).ToLower());
	}
}