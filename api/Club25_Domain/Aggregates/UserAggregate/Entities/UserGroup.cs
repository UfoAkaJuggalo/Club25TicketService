namespace Club25_Domain.Aggregates.UserAggregate.Entities;

public class UserGroup
{
	public int Id { get; init; }

	public string Name { get; init; } = null!;

	public virtual ICollection<User> Users { get; init; } = new List<User>();
}