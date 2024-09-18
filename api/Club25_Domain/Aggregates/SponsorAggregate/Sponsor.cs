using Club25_Domain.Aggregates.SponsorAggregate.Entities;
using Club25_Domain.Aggregates.SponsorAggregate.ValueObjects;
using Club25_Domain.Common.Entities;

namespace Club25_Domain.Aggregates.SponsorAggregate;

public record Sponsor : Organization
{
	public SponsorContactVO Contact { get; set; }
	public ICollection<SponsorDescription> Descriptions { get; set; } = new List<SponsorDescription>();
	public ICollection<Link> Links { get; set; } = new List<Link>();
	public ICollection<SponsorRepresentative> SponsorAgents { get; set; } = new List<SponsorRepresentative>();
	public ICollection<SponsorContract> SponsorContracts { get; set; } = new List<SponsorContract>();
}