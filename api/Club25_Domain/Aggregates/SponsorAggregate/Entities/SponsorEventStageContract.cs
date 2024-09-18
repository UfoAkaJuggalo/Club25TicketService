using Club25_Domain.Aggregates.EventAggregate.Entities;

namespace Club25_Domain.Aggregates.SponsorAggregate.Entities;

public record SponsorEventStageContract : SponsorContract
{
	public EventStageLineup Lineup { get; set; }
	public int LineupId { get; set; }
}