using Club25_Domain.Aggregates.PromoterAgencyAggregate.Entities;

namespace Club25_Domain.Common.Entities;

public sealed class Tag
{
	public int Id { get; set; }
	public required string Name { get; set; }
	public ICollection<Band> Bands { get; init; } = new List<Band>();
	public ICollection<Artist> Artists { get; set; } = new List<Artist>();
}