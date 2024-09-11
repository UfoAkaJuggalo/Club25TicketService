using Club25_Domain.Aggregates.VenueAggregate;

namespace Club25_Domain.Aggregates.SponsorAggregate.Entities;

public sealed class SponsorVenueContract : SponsorContract
{
	public Venue Venue { get; set; }
	public int VenueId { get; set; }
}