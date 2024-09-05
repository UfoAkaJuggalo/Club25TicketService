using Club25_Domain.Aggregates.ClientAggregate.Entities;
using Club25_Domain.Aggregates.TicketPoolAggregate.Entities;

namespace Club25_Domain.Aggregates.ClientAggregate;

public class Client
{
	public int Id { get; init; }

	public int IdPerson { get; init; }

	public string? Phone { get; init; }

	public virtual PersonObsolete IdPersonNavigation { get; init; } = null!;

	public virtual ICollection<Ticket> Tickets { get; init; } = new List<Ticket>();
}