using Club25_Domain.Aggregates.PromoterAgencyAggregate;
using Club25_Domain.Aggregates.TicketAgencyAggregate.Entities;
using Club25_Domain.Aggregates.TicketAgencyAggregate.ValueObjects;
using Club25_Domain.Aggregates.TicketPoolAggregate;
using Club25_Domain.Common.Entities;

namespace Club25_Domain.Aggregates.TicketAgencyAggregate;

public sealed class TicketAgency : Organization
{
	public required TicketAgencyContactVO Contact { get; init; }
	public ICollection<TicketAgent> TicketAgents { get; init; } = new List<TicketAgent>();
	public ICollection<PromoterAgency> PromoterAgencies { get; init; } = new List<PromoterAgency>();
	public ICollection<TicketPool> TicketPools { get; set; } = new List<TicketPool>();
}