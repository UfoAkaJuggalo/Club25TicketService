namespace Club25_Domain.Aggregates.EventAggregate.Entities;

public class FeaturedEvent
{
	public int IdEvent { get; init; }

	public virtual Event IdEventNavigation { get; init; } = null!;
}