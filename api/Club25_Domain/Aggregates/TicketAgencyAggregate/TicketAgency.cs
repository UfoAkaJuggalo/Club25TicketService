using Club25_Domain.Aggregates.TicketAgencyAggregate.Entities;
using Club25_Domain.Aggregates.TicketAgencyAggregate.ValueObjects;

namespace Club25_Domain.Aggregates.TicketAgencyAggregate;

public sealed class TicketAgency
{
	public int Id { get; init; }
	public required string Name { get; init; }
	public required TicketAgencyContactVO Contact { get; set; }
	public ICollection<TicketAgent> TicketAgents { get; set; } = new List<TicketAgent>();
}