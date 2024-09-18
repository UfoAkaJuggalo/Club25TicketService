using Club25_Domain.Aggregates.VenueAggregate.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration.Club25Context.VenueAggregate;

public sealed class StageConfiguration : IEntityTypeConfiguration<Stage>
{
	public void Configure(EntityTypeBuilder<Stage> builder)
	{
		builder.ToTable(nameof(Stage))
		       .HasKey(x => x.Id);

		builder.HasMany(m => m.Sectors)
		       .WithMany(s => s.Stages);

		builder.HasMany(m => m.StageManagers)
		       .WithOne(o => o.Stage);

		var columnOrder = 0;

		builder.Property(p => p.Id)
		       .HasColumnOrder(columnOrder++)
		       .HasColumnName(nameof(Stage.Id).ToLower())
		       .UseIdentityColumn();

		builder.Property(p => p.Name)
		       .HasColumnOrder(columnOrder++)
		       .HasMaxLength(25)
		       .HasColumnName(nameof(Stage.Name).ToLower());

		builder.Property(p => p.Capacity)
		       .HasColumnOrder(columnOrder++)
		       .HasColumnName(nameof(Stage.Capacity).ToLower());

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