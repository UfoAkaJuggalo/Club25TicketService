using Club25_Domain.Aggregates.BandAggregate;

namespace Club25_Domain.Aggregates.EventAggregate.Entities;

public sealed class LineupEntry
{
	public int Id { get; set; }
	public DateTime StartTime { get; init; }
	public DateTime EndTime { get; init; }
	public Band Band { get; set; }
	public EventStageLineup Lineup { get; set; }
	public int BandId { get; set; }
	public int EventStageLineupId { get; set; }
}