using Club25_Domain.Aggregates.SponsorAggregate.Enums;
using Club25_Domain.Aggregates.SponsorAggregate.ValueObjects;

namespace Club25_Domain.Aggregates.SponsorAggregate.Entities;

public abstract class SponsorContract
{
	public int Id { get; set; }
	public Sponsor Sponsor { get; set; }
	public int SponsorId { get; set; }
	public SponsorPriceVO? Price { get; set; }
	public SponsorType SponsorType { get; set; } = SponsorType.simple;
	public DateTime Start { get; set; } = DateTime.Now;
	public DateTime End { get; set; } = DateTime.MaxValue;
	public ContractType ContractType { get; set; }
	public ICollection<SponsorRepresentative> Representatives { get; set; } = new List<SponsorRepresentative>();
	public ICollection<SponsorContractDescription> Descriptions { get; set; } = new List<SponsorContractDescription>();
}