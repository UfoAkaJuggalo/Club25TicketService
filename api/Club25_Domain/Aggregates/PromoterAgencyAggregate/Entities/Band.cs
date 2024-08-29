using Club25_Domain.Aggregates.PromoterAgencyAggregate.ValueObjects;
using Club25_Domain.Common.Entities;

namespace Club25_Domain.Aggregates.PromoterAgencyAggregate.Entities;

public sealed class Band
{
	public int Id { get; set; }
	public required string Name { get; set; }
	public PromoterAgencyPriceVO? PriceMin { get; set; }
	public PromoterAgencyPriceVO? PriceMax { get; set; }
	public PromoterAgency PromoterAgency { get; set; } = null!;
	public int AgencyId { get; set; }
	public int AgentId { get; set; }
	public ICollection<Promoter> Promoters { get; set; } = new List<Promoter>();
	public ICollection<BandDescription> Descriptions { get; set; } = new List<BandDescription>();
	public ICollection<Artist> Members { get; set; } = new List<Artist>();
	public ICollection<Link> Links { get; set; } = new List<Link>();
	public ICollection<Tag> Tags { get; set; } = new List<Tag>();
}