using Club25_Domain.Common.Entities;

namespace Club25_Domain.Aggregates.EventAggregate.Entities;

public sealed class EventDescription : Description
{
	public Event Event { get; init; }
	public int EventId { get; init; }
}