using Club25_Domain.Common.Entities;

namespace Club25_Domain.Aggregates.TicketPoolAggregate.Entities;

public sealed class DiscountName : Description
{
	public Discount Discount { get; set; }
	public int DiscountId { get; set; }
}