using Club25_Domain.Aggregates.TicketPoolAggregate.Entities;

namespace Club25_Domain.Aggregates.TicketPoolAggregate;

public class TicketPool
{
	public int Id { get; init; }

	public int IdTicketType { get; init; }

	public int IdTicketMedia { get; init; }


	public int IdVendor { get; init; }

	public int IdPrice { get; init; }

	public int Amount { get; init; }

	public DateTime? DateStart { get; init; }

	public DateTime DateEnd { get; init; }

	public decimal? Profit { get; init; }


	//public virtual Price IdPriceNavigation { get; init; } = null!;

	public virtual TicketMediaType IdTicketMediaNavigation { get; init; } = null!;

	public virtual TicketType IdTicketTypeNavigation { get; init; } = null!;

	public virtual Vendor IdVendorNavigation { get; init; } = null!;

	public virtual ICollection<Ticket> Tickets { get; init; } = new List<Ticket>();
}