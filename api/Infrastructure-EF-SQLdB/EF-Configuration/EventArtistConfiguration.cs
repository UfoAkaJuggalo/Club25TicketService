using Club25_Domain.Aggregates.EventAggregate.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration;

public sealed class EventArtistConfiguration : IEntityTypeConfiguration<EventArtist>
{
	public void Configure(EntityTypeBuilder<EventArtist> builder)
	{
		builder.ToTable(nameof(EventArtist))
		       .HasNoKey();

		builder.HasOne(d => d.IdArtistNavigation).WithMany()
		       .HasForeignKey(d => d.IdArtist)
		       .OnDelete(DeleteBehavior.ClientSetNull)
		       .HasConstraintName("FK_EventArtists_Artist");

		builder.HasOne(d => d.IdEventNavigation).WithMany()
		       .HasForeignKey(d => d.IdEvent)
		       .OnDelete(DeleteBehavior.ClientSetNull)
		       .HasConstraintName("FK_EventArtists_Event");

		builder.Property(e => e.IdArtist).HasColumnName("idArtist");
		builder.Property(e => e.IdEvent).HasColumnName("idEvent");
	}
}