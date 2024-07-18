using Club25_Domain.CommonEntities;

namespace Club25_Domain.Agregates.AgencyAgregate.Entities;

public sealed class Artist
{
	public int Id { get; set; }
	public string? Name { get; set; }
	public string? Surname { get; set; }
	public string? StageName { get; set; }

	public ICollection<ArtistDescription> ArtistDescriptions { get; set; } = new List<ArtistDescription>();
	public ICollection<Link>? Links { get; set; }
	public ICollection<Tag>? Tags { get; set; }
	public ICollection<Band>? Bands { get; set; }
}