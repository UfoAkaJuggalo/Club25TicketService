using Club25_Domain.Aggregates.PromoterAgencyAggregate.ValueObjects;
using Club25_Domain.Common.Entities;

namespace Club25_Domain.Aggregates.PromoterAgencyAggregate.Entities;

public sealed class Promoter : Person
{
	public PromoterAgency PromoterAgency { get; set; }
	public required PromoterAgencyContactVO Contact { get; set; }
	public ICollection<Band>? Bands { get; set; }
	public int PromoterAgencyId { get; set; }
}