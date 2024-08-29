namespace Club25_Domain.Aggregates.TicketPoolAggregate.Entities;

public class TicketMediaType
{
	public int Id { get; set; }

	public string Name { get; set; } = null!;

	public virtual ICollection<TicketPool> TicketPools { get; set; } = new List<TicketPool>();
}