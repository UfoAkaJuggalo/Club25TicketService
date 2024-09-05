namespace Club25_Domain.Aggregates.EventAggregate.Entities;

public class Language
{
	public int Id { get; init; }

	public string Name { get; init; } = null!;

	public string ShortName { get; init; } = null!;

	public virtual ICollection<Culture> Cultures { get; init; } = new List<Culture>();
}