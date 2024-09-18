using Club25_Domain.Aggregates.EventAggregate.Entities;
using Club25_Domain.Aggregates.SponsorAggregate.Entities;
using Club25_Domain.Aggregates.TicketPoolAggregate;
using Club25_Domain.Aggregates.VenueAggregate;
using Club25_Domain.Common.Entities;

namespace Club25_Domain.Aggregates.EventAggregate;

public sealed record Event : Organization
{
	public DateTime StartDate { get; init; }
	public DateTime EndDate { get; init; }
	public ICollection<Venue> Venues { get; set; } = new List<Venue>();
	public ICollection<Link> Links { get; init; } = new List<Link>();
	public ICollection<EventDescription> Descriptions { get; set; } = new List<EventDescription>();

	public ICollection<Tag> Tags { get; set; } = new List<Tag>();

	public ICollection<EventStageLineup> Lineups { get; set; } = new List<EventStageLineup>();

	public ICollection<SponsorEventContract> SponsorContracts { get; set; } = new List<SponsorEventContract>();
	public ICollection<TicketPool> TicketPools { get; init; } = new List<TicketPool>();
}