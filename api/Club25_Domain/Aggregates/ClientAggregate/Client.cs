using Club25_Domain.Aggregates.ClientAggregate.Entities;
using Club25_Domain.Aggregates.TicketPoolAggregate.Entities;

namespace Club25_Domain.Aggregates.ClientAggregate;

public class Client
{
	public int Id { get; set; }

	public int IdPerson { get; set; }

	public string? Phone { get; set; }

	public virtual PersonObsolete IdPersonNavigation { get; set; } = null!;

	public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}