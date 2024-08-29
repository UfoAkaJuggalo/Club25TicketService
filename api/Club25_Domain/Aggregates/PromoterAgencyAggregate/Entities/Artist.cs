using Club25_Domain.Common.Entities;

namespace Club25_Domain.Aggregates.PromoterAgencyAggregate.Entities;

public sealed class Artist : Person
{
	public string? StageName { get; set; }
	public ICollection<ArtistDescription> ArtistDescriptions { get; set; } = new List<ArtistDescription>();
	public ICollection<Link>? Links { get; set; }
	public ICollection<Tag>? Tags { get; set; }
	public ICollection<Band>? Bands { get; set; }
}