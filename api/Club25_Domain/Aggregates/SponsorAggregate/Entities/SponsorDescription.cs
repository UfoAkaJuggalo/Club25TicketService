using Club25_Domain.Common.Entities;

namespace Club25_Domain.Aggregates.SponsorAggregate.Entities;

public sealed record SponsorDescription : Description
{
	public Sponsor Sponsor { get; set; }
	public int SponsorId { get; set; }
}