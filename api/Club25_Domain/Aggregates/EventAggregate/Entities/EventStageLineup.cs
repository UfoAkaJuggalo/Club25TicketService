using Club25_Domain.Aggregates.SponsorAggregate.Entities;
using Club25_Domain.Aggregates.VenueAggregate.Entities;
using Club25_Domain.Common.Entities;

namespace Club25_Domain.Aggregates.EventAggregate.Entities;

public sealed class EventStageLineup
{
	public int Id { get; set; }
	public string? Name { get; set; }
	public Event Event { get; set; }
	public Stage Stage { get; set; }
	public int EventId { get; set; }
	public int StageId { get; set; }
	public ICollection<EventStageDescription> Descriptions { get; set; } = new List<EventStageDescription>();

	public ICollection<SponsorEventStageContract> SponsorStageContracts { get; set; } =
		new List<SponsorEventStageContract>();

	public ICollection<LineupEntry> Lineups { get; set; } = new List<LineupEntry>();
	public ICollection<Tag> Tags { get; set; } = new List<Tag>();
}