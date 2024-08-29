using Club25_Domain.Aggregates.EventAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration;

public sealed class EventConfiguration : IEntityTypeConfiguration<Event>
{
	public void Configure(EntityTypeBuilder<Event> builder)
	{
		builder.ToTable("Event");

		builder.HasOne(d => d.IdVenueNavigation).WithMany(p => p.Events)
		       .HasForeignKey(d => d.IdVenue)
		       .OnDelete(DeleteBehavior.ClientSetNull)
		       .HasConstraintName("FK_Event_Venue");

		builder.Property(e => e.IdVenue).HasColumnName("idVenue");
		builder.Property(e => e.Id)
		       .ValueGeneratedNever()
		       .HasColumnName("id");
		builder.Property(e => e.Date).HasColumnName("date");
		builder.Property(e => e.FbEvent)
		       .HasMaxLength(50)
		       .HasColumnName("fbEvent");
		builder.Property(e => e.Flyer).HasColumnName("flyer");
	}
}