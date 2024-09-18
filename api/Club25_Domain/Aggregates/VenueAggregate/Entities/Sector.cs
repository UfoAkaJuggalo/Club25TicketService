using Club25_Domain.Aggregates.VenueAggregate.Enums;
using Club25_Domain.Common.Entities;

namespace Club25_Domain.Aggregates.VenueAggregate.Entities;

public sealed record Sector
{
	public int Id { get; init; }
	public string? Name { get; init; }
	public int Capacity { get; init; }
	public SectorType SectorType { get; init; } = SectorType.standing;
	public Link? Plan { get; init; }
	public int? LinkId { get; init; }
	public ICollection<Seat> Seats { get; init; } = new List<Seat>();
	public ICollection<Stage> Stages { get; init; } = new List<Stage>();
}