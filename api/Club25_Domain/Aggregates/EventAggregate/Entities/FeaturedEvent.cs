namespace Club25_Domain.Aggregates.EventAggregate.Entities;

public class FeaturedEvent
{
	public int IdEvent { get; set; }

	public virtual Event IdEventNavigation { get; set; } = null!;
}