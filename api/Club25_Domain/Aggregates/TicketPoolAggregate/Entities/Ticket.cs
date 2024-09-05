using Club25_Domain.Aggregates.ClientAggregate;

namespace Club25_Domain.Aggregates.TicketPoolAggregate.Entities;

public class Ticket
{
	public int Id { get; init; }

	public int IdClient { get; init; }

	public DateTime SoldDate { get; init; }

	public int IdTicketPool { get; init; }

	public int? SeatNumber { get; init; }

	public string Hash { get; init; } = null!;

	public virtual Client IdClientNavigation { get; init; } = null!;

	public virtual TicketPool IdTicketPoolNavigation { get; init; } = null!;
}