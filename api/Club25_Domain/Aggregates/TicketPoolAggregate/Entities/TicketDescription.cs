using Club25_Domain.Common.Entities;

namespace Club25_Domain.Aggregates.TicketPoolAggregate.Entities;

public record TicketDescription : Description
{
	public TicketPool TicketPool { get; set; }
	public int TicketPoolId { get; set; }
}