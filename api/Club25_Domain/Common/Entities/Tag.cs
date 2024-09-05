using Club25_Domain.Aggregates.BandAggregate;
using Club25_Domain.Aggregates.BandAggregate.Entities;

namespace Club25_Domain.Common.Entities;

public sealed class Tag
{
	public int Id { get; init; }
	public required string Name { get; init; }
	public ICollection<Band> Bands { get; init; } = new List<Band>();
	public ICollection<Artist> Artists { get; init; } = new List<Artist>();
}