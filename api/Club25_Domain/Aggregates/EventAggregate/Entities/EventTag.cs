using Tag = Club25_Domain.Common.Entities.Tag;

namespace Club25_Domain.Aggregates.EventAggregate.Entities;

public class EventTag
{
	public int IdEvent { get; set; }

	public int IdTag { get; set; }

	public virtual Event IdEventNavigation { get; set; } = null!;

	public virtual Tag IdTagNavigation { get; set; } = null!;
}