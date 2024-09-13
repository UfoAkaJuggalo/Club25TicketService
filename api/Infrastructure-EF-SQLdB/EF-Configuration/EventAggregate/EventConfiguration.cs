using Club25_Domain.Aggregates.EventAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure_EF_SQLdB.EF_Configuration.EventAggregate;

public sealed class EventConfiguration : IEntityTypeConfiguration<Event>
{
	public void Configure(EntityTypeBuilder<Event> builder)
	{
		builder.ToTable(nameof(Event));

		builder.HasMany(m => m.Descriptions)
		       .WithOne(m => m.Event)
		       .HasForeignKey(m => m.EventId)
		       .OnDelete(DeleteBehavior.ClientSetNull);

		builder.HasMany(d => d.Venues)
		       .WithMany(p => p.Events);

		builder.HasMany(m => m.Tags)
		       .WithMany(t => t.Events);

		builder.HasMany(m => m.Links)
		       .WithOne();

		builder.HasMany(m => m.SponsorContracts)
		       .WithOne(s => s.Event)
		       .HasForeignKey(f => f.EventId)
		       .OnDelete(DeleteBehavior.ClientSetNull);

		builder.HasMany(m => m.Lineups)
		       .WithOne(l => l.Event)
		       .HasForeignKey(l => l.EventId)
		       .OnDelete(DeleteBehavior.ClientSetNull);

		builder.HasMany(m => m.TicketPools)
		       .WithOne(o => o.Event)
		       .HasForeignKey(o => o.EventId)
		       .OnDelete(DeleteBehavior.ClientSetNull);

		builder.Property(e => e.StartDate)
		       .HasColumnName(nameof(Event.StartDate).ToLower())
		       .HasConversion(new DateTimeToStringConverter());

		builder.Property(e => e.EndDate)
		       .HasColumnName(nameof(Event.EndDate).ToLower())
		       .HasConversion(new DateTimeToStringConverter());
	}
}