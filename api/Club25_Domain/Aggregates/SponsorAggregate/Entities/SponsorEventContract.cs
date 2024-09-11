using Club25_Domain.Aggregates.EventAggregate;

namespace Club25_Domain.Aggregates.SponsorAggregate.Entities;

public sealed class SponsorEventContract : SponsorContract
{
	public Event Event { get; init; }
	public int EventId { get; init; }
}