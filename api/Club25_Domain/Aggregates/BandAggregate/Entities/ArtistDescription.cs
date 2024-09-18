using Club25_Domain.Common.Entities;

namespace Club25_Domain.Aggregates.BandAggregate.Entities;

public sealed record ArtistDescription : Description
{
	public int ArtistId { get; init; }
	public Artist Artist { get; init; }
}