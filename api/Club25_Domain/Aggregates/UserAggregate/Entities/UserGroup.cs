namespace Club25_Domain.Aggregates.UserAggregate.Entities;

public class UserGroup
{
	public int Id { get; set; }

	public string Name { get; set; } = null!;

	public virtual ICollection<User> Users { get; set; } = new List<User>();
}