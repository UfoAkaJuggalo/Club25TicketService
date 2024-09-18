using Club25_Domain.Common.Entities;

namespace Club25_Domain.Aggregates.BandAggregate.Entities;

public sealed record BandDescription : Description
{
	public int BandId { get; init; }
	public Band Band { get; init; }
}