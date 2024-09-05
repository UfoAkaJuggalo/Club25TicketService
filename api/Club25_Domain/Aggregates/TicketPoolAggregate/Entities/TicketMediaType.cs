namespace Club25_Domain.Aggregates.TicketPoolAggregate.Entities;

public class TicketMediaType
{
	public int Id { get; init; }

	public string Name { get; init; } = null!;

	public virtual ICollection<TicketPool> TicketPools { get; init; } = new List<TicketPool>();
}