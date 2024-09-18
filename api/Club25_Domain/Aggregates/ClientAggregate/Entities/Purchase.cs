using Club25_Domain.Aggregates.ClientAggregate.Enums;

namespace Club25_Domain.Aggregates.ClientAggregate.Entities;

public sealed record Purchase
{
	public Guid Id { get; set; }
	public PurchaseStatus PurchaseStatus { get; set; }
	public DateTime PurchaseDate { get; set; }
	public Guid TicketId { get; set; }
	public Client Client { get; set; }
	public Guid ClientId { get; set; }
}