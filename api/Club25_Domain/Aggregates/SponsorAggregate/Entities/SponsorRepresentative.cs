using Club25_Domain.Aggregates.SponsorAggregate.ValueObjects;
using Club25_Domain.Common.Entities;

namespace Club25_Domain.Aggregates.SponsorAggregate.Entities;

public sealed record SponsorRepresentative : Person
{
	public SponsorContactVO Contact { get; set; }
	public Sponsor Sponsor { get; set; }
	public int SponsorId { get; set; }
}