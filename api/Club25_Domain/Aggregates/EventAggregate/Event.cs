using Club25_Domain.Aggregates.TicketPoolAggregate;
using Club25_Domain.Aggregates.VenueAggregate;

namespace Club25_Domain.Aggregates.EventAggregate;

public class Event
{
	public int Id { get; init; }

	public DateTime Date { get; init; }

	public int VenueId { get; init; }

	public string? FbEvent { get; init; }

	public byte[] Flyer { get; init; } = null!;

	public virtual Venue Venue { get; init; } = null!;

	public virtual ICollection<TicketPool> TicketPools { get; init; } = new List<TicketPool>();
}