using Club25_Domain.Aggregates.EventAggregate.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration;

public sealed class EventMediaPartnerConfiguration : IEntityTypeConfiguration<EventMediaPartner>
{
	public void Configure(EntityTypeBuilder<EventMediaPartner> builder)
	{
		builder.HasNoKey()
		       .ToTable("EventMediaPartner");

		builder.HasOne(d => d.IdEventNavigation).WithMany()
		       .HasForeignKey(d => d.IdEvent)
		       .OnDelete(DeleteBehavior.ClientSetNull)
		       .HasConstraintName("FK_EventMediaPartner_Event");

		builder.HasOne(d => d.IdSponsorNavigation).WithMany()
		       .HasForeignKey(d => d.IdSponsor)
		       .OnDelete(DeleteBehavior.ClientSetNull)
		       .HasConstraintName("FK_EventMediaPartner_Sponsor");

		builder.HasOne(d => d.PriceNavigation).WithMany()
		       .HasForeignKey(d => d.Price)
		       .HasConstraintName("FK_EventMediaPartner_Price");

		builder.Property(e => e.Description)
		       .HasMaxLength(250)
		       .HasColumnName("description");
		builder.Property(e => e.IdEvent).HasColumnName("idEvent");
		builder.Property(e => e.IdSponsor).HasColumnName("idSponsor");
		builder.Property(e => e.Price).HasColumnName("price");
	}
}