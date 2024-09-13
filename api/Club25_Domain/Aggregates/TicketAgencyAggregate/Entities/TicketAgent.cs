using Club25_Domain.Aggregates.PromoterAgencyAggregate;
using Club25_Domain.Aggregates.TicketAgencyAggregate.ValueObjects;
using Club25_Domain.Aggregates.TicketPoolAggregate;
using Club25_Domain.Common.Entities;

namespace Club25_Domain.Aggregates.TicketAgencyAggregate.Entities;

public sealed class TicketAgent : Person
{
	public required TicketAgencyContactVO Contact { get; init; }
	public required TicketAgency TicketAgency { get; init; }
	public required int TicketAgencyId { get; init; }
	public ICollection<PromoterAgency> PromoterAgencies { get; } = new List<PromoterAgency>();
	public ICollection<TicketPool> TicketPools { get; set; } = new List<TicketPool>();
}