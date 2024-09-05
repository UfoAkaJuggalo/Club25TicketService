namespace Club25_Domain.Aggregates.EventAggregate.Entities;

public class Culture
{
	public int Id { get; init; }

	public string Name { get; init; } = null!;

	public string ShortName { get; init; } = null!;

	public int IdCurrency { get; init; }

	public int IdLanguage { get; init; }

	public virtual Currency IdCurrencyNavigation { get; init; } = null!;

	public virtual Language IdLanguageNavigation { get; init; } = null!;
}