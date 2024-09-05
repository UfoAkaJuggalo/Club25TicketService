namespace Club25_Domain.Aggregates.EventAggregate.Entities;

public class Currency
{
	public int Id { get; init; }

	public string Name { get; init; } = null!;

	public string Shortname { get; init; } = null!;

	public virtual ICollection<Culture> Cultures { get; init; } = new List<Culture>();

	public virtual ICollection<Price> Prices { get; init; } = new List<Price>();
}