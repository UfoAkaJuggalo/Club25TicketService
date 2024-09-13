using Club25_Domain.Common.Entities;

namespace Club25_Domain.Aggregates.TicketPoolAggregate.Entities;

public class TicketDescription : Description
{
	public TicketPool TicketPool { get; set; }
	public int TicketPoolId { get; set; }
}