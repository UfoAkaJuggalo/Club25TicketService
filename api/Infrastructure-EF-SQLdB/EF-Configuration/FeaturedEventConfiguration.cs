using Club25_Domain.Aggregates.EventAggregate.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration;

public sealed class FeaturedEventConfiguration : IEntityTypeConfiguration<FeaturedEvent>
{
	public void Configure(EntityTypeBuilder<FeaturedEvent> builder)
	{
		builder.ToTable(nameof(FeaturedEvent))
		       .HasNoKey();

		builder.HasOne(d => d.IdEventNavigation).WithMany()
		       .HasForeignKey(d => d.IdEvent)
		       .OnDelete(DeleteBehavior.ClientSetNull)
		       .HasConstraintName("FK_FeaturedEvents_Event");

		builder.Property(e => e.IdEvent).HasColumnName("idEvent");
	}
}