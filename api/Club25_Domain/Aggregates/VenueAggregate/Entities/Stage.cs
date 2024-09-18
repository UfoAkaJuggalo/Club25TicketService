using Club25_Domain.Aggregates.VenueAggregate.ValueObjects;

namespace Club25_Domain.Aggregates.VenueAggregate.Entities;

public sealed record Stage
{
	public int Id { get; init; }
	public string? Name { get; init; }
	public int? Capacity { get; init; }
	public VenuePriceVO? PriceMin { get; init; }
	public VenuePriceVO? PriceMax { get; init; }
	public Venue Venue { get; init; } = null!;
	public int VenueId { get; init; }
	public ICollection<Sector> Sectors { get; init; } = new List<Sector>();
	public ICollection<StageToStageManager> StageManagers { get; init; } = new List<StageToStageManager>();
}