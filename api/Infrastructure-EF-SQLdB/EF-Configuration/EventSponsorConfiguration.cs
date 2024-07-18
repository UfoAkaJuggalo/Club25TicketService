using Club25_Domain.Agregates.EventAgregate.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration;

public sealed class EventSponsorConfiguration : IEntityTypeConfiguration<EventSponsor>
{
	public void Configure(EntityTypeBuilder<EventSponsor> builder)
	{
		builder.HasNoKey()
		       .ToTable("EventSponsor");

		builder.HasOne(d => d.IdEventNavigation).WithMany()
		       .HasForeignKey(d => d.IdEvent)
		       .OnDelete(DeleteBehavior.ClientSetNull)
		       .HasConstraintName("FK_EventSponsor_Event");

		builder.HasOne(d => d.IdPriceNavigation).WithMany()
		       .HasForeignKey(d => d.IdPrice)
		       .HasConstraintName("FK_EventSponsor_Price");

		builder.HasOne(d => d.IdSponsorNavigation).WithMany()
		       .HasForeignKey(d => d.IdSponsor)
		       .OnDelete(DeleteBehavior.ClientSetNull)
		       .HasConstraintName("FK_EventSponsor_Sponsor");

		builder.Property(e => e.IdEvent).HasColumnName("idEvent");
		builder.Property(e => e.IdPrice).HasColumnName("idPrice");
		builder.Property(e => e.IdSponsor).HasColumnName("idSponsor");
	}
}