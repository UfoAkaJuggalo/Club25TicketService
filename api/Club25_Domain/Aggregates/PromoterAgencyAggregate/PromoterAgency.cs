using Club25_Domain.Aggregates.PromoterAgencyAggregate.Entities;
using Club25_Domain.Aggregates.PromoterAgencyAggregate.ValueObjects;
using Club25_Domain.Aggregates.TicketAgencyAggregate.Entities;

namespace Club25_Domain.Aggregates.PromoterAgencyAggregate;

public sealed class PromoterAgency
{
	public int Id { get; init; }
	public required string Name { get; init; }
	public required PromoterAgencyContactVO Contact { get; init; }
	public ICollection<Band> Bands { get; init; } = new List<Band>();
	public ICollection<Promoter> Promoters { get; set; } = new List<Promoter>();
	public ICollection<TicketAgent> Accountants { get; set; } = new List<TicketAgent>();
}