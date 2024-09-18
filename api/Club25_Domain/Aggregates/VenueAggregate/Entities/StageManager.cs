using Club25_Domain.Aggregates.VenueAggregate.ValueObjects;
using Club25_Domain.Common.Entities;

namespace Club25_Domain.Aggregates.VenueAggregate.Entities;

public sealed record StageManager : Person
{
	public required VenueContactVO Contact { get; init; }
	public required Venue Venue { get; init; }
	public required int VenueId { get; init; }
	public ICollection<StageToStageManager> Stages { get; init; } = new List<StageToStageManager>();
}