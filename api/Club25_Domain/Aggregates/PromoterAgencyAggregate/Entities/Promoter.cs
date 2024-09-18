using Club25_Domain.Aggregates.PromoterAgencyAggregate.ValueObjects;
using Club25_Domain.Common.Entities;

namespace Club25_Domain.Aggregates.PromoterAgencyAggregate.Entities;

public sealed record Promoter : Person
{
	public required PromoterAgencyContactVO Contact { get; init; }
	public required PromoterAgency PromoterAgency { get; init; }
	public required int PromoterAgencyId { get; init; }
}