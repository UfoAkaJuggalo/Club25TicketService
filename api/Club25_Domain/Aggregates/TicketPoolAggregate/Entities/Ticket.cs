using Club25_Domain.Aggregates.TicketPoolAggregate.Enums;
using Club25_Domain.Aggregates.TicketPoolAggregate.ValueObjects;

namespace Club25_Domain.Aggregates.TicketPoolAggregate.Entities;

public record Ticket
{
	public Guid Id { get; init; }
	public DateTime SoldDate { get; init; }
	public string? SeatNumber { get; init; }
	public TicketStatus TicketStatus { get; set; } = TicketStatus.available;
	public TicketPriceVO TicketPrice { get; set; }
	public TicketPool TicketPool { get; set; }
	public int TicketPoolId { get; set; }
	public TicketMediaType MediaType { get; set; }

	public ICollection<Discount> Discounts { get; set; } = new List<Discount>();
	//public int IdClient { get; init; }
	//public virtual Client IdClientNavigation { get; init; } = null!;
}