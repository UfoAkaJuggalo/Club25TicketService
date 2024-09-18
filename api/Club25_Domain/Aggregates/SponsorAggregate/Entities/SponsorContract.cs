using Club25_Domain.Aggregates.SponsorAggregate.Enums;
using Club25_Domain.Aggregates.SponsorAggregate.ValueObjects;

namespace Club25_Domain.Aggregates.SponsorAggregate.Entities;

public abstract record SponsorContract
{
	public int Id { get; set; }
	public Sponsor Sponsor { get; set; }
	public int SponsorId { get; set; }
	public SponsorPriceVO? Price { get; set; }
	public SponsorType SponsorType { get; set; } = SponsorType.simple;
	public DateOnly Start { get; set; } = DateOnly.FromDateTime(DateTime.Now);
	public DateOnly End { get; set; } = DateOnly.MaxValue;
	public ContractType ContractType { get; set; }
	public ICollection<SponsorRepresentative> Representatives { get; set; } = new List<SponsorRepresentative>();
	public ICollection<SponsorContractDescription> Descriptions { get; set; } = new List<SponsorContractDescription>();
}