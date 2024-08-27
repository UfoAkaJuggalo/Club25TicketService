using Club25_Domain.Agregates.AgencyAgregate.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration;

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

		builder.HasOne(m => m.Agent)
		       .WithMany(m => m.Bands)
		       .HasForeignKey(k => k.AgentId)
		       .OnDelete(DeleteBehavior.ClientSetNull)
		       .HasConstraintName("FK_Band_Agent");

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

		builder.OwnsOne(o => o.PriceMin, navigationBuilder =>
		{
			navigationBuilder.Property(p => p.Price)
			                 .HasColumnOrder(columnOrder++)
			                 .HasPrecision(10, 2);
			navigationBuilder.Property(p => p.Currency)
			                 .HasColumnOrder(columnOrder++)
			                 .HasConversion<string>();
		});

		builder.OwnsOne(o => o.PriceMax, navigationBuilder =>
		{
			navigationBuilder.Property(p => p.Price)
			                 .HasColumnOrder(columnOrder++)
			                 .HasPrecision(10, 2);
			navigationBuilder.Property(p => p.Currency)
			                 .HasColumnOrder(columnOrder++)
			                 .HasConversion<string>();
		});
	}
}