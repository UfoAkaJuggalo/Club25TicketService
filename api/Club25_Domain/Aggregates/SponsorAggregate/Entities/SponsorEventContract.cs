using Club25_Domain.Aggregates.EventAggregate;

namespace Club25_Domain.Aggregates.SponsorAggregate.Entities;

public sealed record SponsorEventContract : SponsorContract
{
	public Event Event { get; init; }
	public int EventId { get; init; }
}