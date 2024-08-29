using Club25_Domain.Aggregates.TicketPoolAggregate;
using Club25_Domain.Aggregates.VenueAggregate;

namespace Club25_Domain.Aggregates.EventAggregate;

public class Event
{
	public int Id { get; set; }

	public DateTime Date { get; set; }

	public int IdVenue { get; set; }

	public string? FbEvent { get; set; }

	public byte[] Flyer { get; set; } = null!;

	public virtual Venue IdVenueNavigation { get; set; } = null!;

	public virtual ICollection<TicketPool> TicketPools { get; set; } = new List<TicketPool>();
}