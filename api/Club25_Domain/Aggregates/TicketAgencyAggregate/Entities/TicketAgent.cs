using Club25_Domain.Aggregates.PromoterAgencyAggregate;
using Club25_Domain.Aggregates.TicketAgencyAggregate.ValueObjects;
using Club25_Domain.Common.Entities;

namespace Club25_Domain.Aggregates.TicketAgencyAggregate.Entities;

public sealed class TicketAgent : Person
{
	public required TicketAgencyContactVO Contact { get; set; }
	public TicketAgency TicketAgency { get; set; }
	public int TicketAgencyId { get; set; }
	public ICollection<PromoterAgency> PromoterAgencies { get; } = new List<PromoterAgency>();
}