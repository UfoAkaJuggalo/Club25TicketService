using Club25_Domain.Common.Entities;

namespace Club25_Domain.Aggregates.SponsorAggregate.Entities;

public sealed record SponsorContractDescription : Description
{
	public SponsorContract Contract { get; set; }
	public int SponsorContractId { get; set; }
}