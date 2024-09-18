using Club25_Domain.Aggregates.TicketPoolAggregate.Entities;

namespace Club25_Domain.Aggregates.TicketPoolAggregate;

public sealed record Discount
{
	public int Id { get; set; }
	public decimal Multipler { get; set; }
	public ICollection<DiscountName> Names { get; set; } = new List<DiscountName>();
	public ICollection<DiscountDescription> DiscountDescriptions { get; set; } = new List<DiscountDescription>();
	public ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}