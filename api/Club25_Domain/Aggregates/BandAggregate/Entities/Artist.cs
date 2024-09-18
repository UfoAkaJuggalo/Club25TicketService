using Club25_Domain.Common.Entities;

namespace Club25_Domain.Aggregates.BandAggregate.Entities;

public sealed record Artist : Person
{
	public string? StageName { get; init; }
	public ICollection<ArtistDescription> ArtistDescriptions { get; init; } = new List<ArtistDescription>();
	public ICollection<Link>? Links { get; init; }
	public ICollection<Tag>? Tags { get; init; }
	public ICollection<Band>? Bands { get; init; }
}