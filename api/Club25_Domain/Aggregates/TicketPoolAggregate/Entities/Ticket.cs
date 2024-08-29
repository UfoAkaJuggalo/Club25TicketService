using Club25_Domain.Aggregates.ClientAggregate;

namespace Club25_Domain.Aggregates.TicketPoolAggregate.Entities;

public class Ticket
{
	public int Id { get; set; }

	public int IdClient { get; set; }

	public DateTime SoldDate { get; set; }

	public int IdTicketPool { get; set; }

	public int? SeatNumber { get; set; }

	public string Hash { get; set; } = null!;

	public virtual Client IdClientNavigation { get; set; } = null!;

	public virtual TicketPool IdTicketPoolNavigation { get; set; } = null!;
}