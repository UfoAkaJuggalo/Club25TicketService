using Club25_Domain.Agregates.AgencyAgregate.ValueObjects;
using Club25_Domain.CommonEntities;

namespace Club25_Domain.Agregates.AgencyAgregate.Entities;

public sealed class Band
{
	public int Id { get; set; }
	public required string Name { get; set; }
	public PriceVO? PriceMin { get; set; }
	public PriceVO? PriceMax { get; set; }
	public Agency Agency { get; set; } = null!;
	public Agent Agent { get; set; }
	public int AgencyId { get; set; }
	public int AgentId { get; set; }
	public ICollection<BandDescription> Descriptions { get; set; } = new List<BandDescription>();
	public ICollection<Artist> Members { get; set; } = new List<Artist>();
	public ICollection<Link> Links { get; set; } = new List<Link>();
	public ICollection<Tag> Tags { get; set; } = new List<Tag>();
}