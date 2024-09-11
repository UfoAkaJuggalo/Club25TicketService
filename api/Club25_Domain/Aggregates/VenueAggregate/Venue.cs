using Club25_Domain.Aggregates.EventAggregate;
using Club25_Domain.Aggregates.SponsorAggregate.Entities;
using Club25_Domain.Aggregates.VenueAggregate.Entities;
using Club25_Domain.Aggregates.VenueAggregate.ValueObjects;
using Club25_Domain.Common.Entities;

namespace Club25_Domain.Aggregates.VenueAggregate;

public sealed class Venue : Organization
{
	public decimal? GpsLatitude { get; init; }
	public decimal? GpsLongitude { get; init; }
	public required VenueContactVO Contact { get; init; }
	public ICollection<Event> Events { get; } = new List<Event>();
	public ICollection<Stage> Stages { get; } = new List<Stage>();
	public ICollection<StageManager> StageManagers { get; } = new List<StageManager>();
	public ICollection<Link>? Links { get; init; }
	public ICollection<SponsorVenueContract> SponsorContracts { get; set; } = new List<SponsorVenueContract>();
}