using Tag = Club25_Domain.Common.Entities.Tag;

namespace Club25_Domain.Aggregates.EventAggregate.Entities;

public class EventTag
{
	public int IdEvent { get; init; }

	public int IdTag { get; init; }

	public virtual Event IdEventNavigation { get; init; } = null!;

	public virtual Tag IdTagNavigation { get; init; } = null!;
}