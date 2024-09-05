namespace Club25_Domain.Aggregates.EventAggregate.Entities;

public class EventDescription
{
	public int IdEvent { get; init; }

	public int IdLanguage { get; init; }

	public string Description { get; init; } = null!;

	public virtual Event IdEventNavigation { get; init; } = null!;

	public virtual Language IdLanguageNavigation { get; init; } = null!;
}