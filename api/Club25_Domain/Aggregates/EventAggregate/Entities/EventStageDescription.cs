using Club25_Domain.Common.Entities;

namespace Club25_Domain.Aggregates.EventAggregate.Entities;

public sealed record EventStageDescription : Description
{
	public EventStageLineup EventStage { get; init; }
	public int EventStageId { get; init; }
}