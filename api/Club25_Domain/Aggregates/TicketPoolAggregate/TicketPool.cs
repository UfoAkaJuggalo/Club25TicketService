using Club25_Domain.Aggregates.TicketPoolAggregate.Entities;

namespace Club25_Domain.Aggregates.TicketPoolAggregate;

public sealed class TicketPool
{
	public int Id { get; init; }

	// public int IdTicketType { get; init; }
	//
	// public int IdTicketMedia { get; init; }


	// public int IdVendor { get; init; }
	//
	// public int IdPrice { get; init; }

	// public int Amount { get; init; }

	public DateTime? DateStart { get; init; }

	public DateTime DateEnd { get; init; }

	public decimal? Profit { get; init; }


	//public virtual Price IdPriceNavigation { get; init; } = null!;

	//public TicketMediaType IdTicketMediaNavigation { get; init; } = null!;

	//public TicketType IdTicketTypeNavigation { get; init; } = null!;

	//public Vendor IdVendorNavigation { get; init; } = null!;

	public ICollection<Ticket> Tickets { get; init; } = new List<Ticket>();
}