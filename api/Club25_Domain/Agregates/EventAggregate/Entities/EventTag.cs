using Tag = Club25_Domain.CommonEntities.Tag;

namespace Club25_Domain.Agregates.EventAgregate.Entities;

public class EventTag
{
	public int IdEvent { get; set; }

	public int IdTag { get; set; }

	public virtual Event IdEventNavigation { get; set; } = null!;

	public virtual Tag IdTagNavigation { get; set; } = null!;
}