using Club25_Domain.Agregates.VenueAgregate.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration;

public sealed class StageConfiguration : IEntityTypeConfiguration<Stage>
{
	public void Configure(EntityTypeBuilder<Stage> builder)
	{
		builder.ToTable("Stage");

		builder.HasOne(d => d.IdPriceMaxNavigation).WithMany(p => p.StageIdPriceMaxNavigations)
		       .HasForeignKey(d => d.IdPriceMax)
		       .HasConstraintName("FK_Stage_Price");

		builder.HasOne(d => d.IdPriceMinNavigation).WithMany(p => p.StageIdPriceMinNavigations)
		       .HasForeignKey(d => d.IdPriceMin)
		       .HasConstraintName("FK_Stage_Price1");

		builder.HasOne(d => d.IdVenueNavigation).WithMany(p => p.Stages)
		       .HasForeignKey(d => d.IdVenue)
		       .OnDelete(DeleteBehavior.ClientSetNull)
		       .HasConstraintName("FK_Stage_Venue");

		builder.Property(e => e.Id)
		       .ValueGeneratedNever()
		       .HasColumnName("id");
		builder.Property(e => e.IdPriceMax).HasColumnName("idPrice_max");
		builder.Property(e => e.IdPriceMin).HasColumnName("idPrice_min");
		builder.Property(e => e.IdVenue).HasColumnName("id_venue");
		builder.Property(e => e.MaxCapacity).HasColumnName("max_capacity");
		builder.Property(e => e.MinCapacity).HasColumnName("min_capacity");
		builder.Property(e => e.Name)
		       .HasMaxLength(25)
		       .HasColumnName("name");
	}
}