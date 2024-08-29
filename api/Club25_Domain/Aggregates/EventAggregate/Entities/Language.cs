namespace Club25_Domain.Aggregates.EventAggregate.Entities;

public class Language
{
	public int Id { get; set; }

	public string Name { get; set; } = null!;

	public string ShortName { get; set; } = null!;

	public virtual ICollection<Culture> Cultures { get; set; } = new List<Culture>();
}