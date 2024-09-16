using Club25_Domain.Aggregates.EventAggregate.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration.Club25Context.EventAggregate;

public sealed class EventStageLineupConfiguration : IEntityTypeConfiguration<EventStageLineup>
{
	public void Configure(EntityTypeBuilder<EventStageLineup> builder)
	{
		builder.ToTable(nameof(EventStageLineup))
		       .HasKey(e => e.Id);

		builder.HasOne(o => o.Stage)
		       .WithMany()
		       .HasForeignKey(o => o.StageId)
		       .OnDelete(DeleteBehavior.Restrict);

		builder.HasMany(m => m.Descriptions)
		       .WithOne(o => o.EventStage)
		       .HasForeignKey(o => o.EventStageId)
		       .OnDelete(DeleteBehavior.ClientSetNull);

		builder.HasMany(m => m.Lineups)
		       .WithOne(o => o.Lineup)
		       .HasForeignKey(f => f.EventStageLineupId);

		builder.HasMany(m => m.Tags)
		       .WithMany(m => m.EventStageLineups);

		builder.HasMany(m => m.SponsorStageContracts)
		       .WithOne(o => o.Lineup)
		       .HasForeignKey(o => o.LineupId)
		       .OnDelete(DeleteBehavior.ClientSetNull);

		var columnOrder = 0;

		builder.Property(p => p.Id)
		       .HasColumnOrder(columnOrder++)
		       .HasColumnName(nameof(EventStageLineup.Id).ToLower())
		       .UseIdentityColumn();

		builder.Property(p => p.Name)
		       .HasColumnOrder(columnOrder++)
		       .HasColumnName(nameof(EventStageLineup.Name).ToLower())
		       .HasMaxLength(64);
	}
}