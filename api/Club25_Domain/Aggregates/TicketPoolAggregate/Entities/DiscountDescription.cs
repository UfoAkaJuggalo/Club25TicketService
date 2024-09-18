using Club25_Domain.Common.Entities;

namespace Club25_Domain.Aggregates.TicketPoolAggregate.Entities;

public sealed record DiscountDescription : Description
{
	public Discount Discount { get; set; }
	public int DiscountId { get; set; }
}