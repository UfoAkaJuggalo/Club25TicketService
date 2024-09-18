using Club25_Domain.Aggregates.PromoterAgencyAggregate.Entities;
using Club25_Domain.Aggregates.PromoterAgencyAggregate.ValueObjects;
using Club25_Domain.Aggregates.TicketAgencyAggregate.Entities;
using Club25_Domain.Common.Entities;

namespace Club25_Domain.Aggregates.PromoterAgencyAggregate;

public record PromoterAgency : Organization
{
	public required PromoterAgencyContactVO Contact { get; init; }
	public ICollection<Promoter> Promoters { get; init; } = new List<Promoter>();
	public ICollection<TicketAgent> Accountants { get; init; } = new List<TicketAgent>();
}