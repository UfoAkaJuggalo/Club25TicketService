namespace Club25_Domain.Aggregates.UserAggregate.Entities;

public sealed class UserGroup
{
	public int Id { get; init; }
	public string Name { get; init; } = null!;
	public string? Description { get; init; } = null!;
	public ICollection<User> Users { get; init; } = new List<User>();
	public ICollection<Permission> Permissions { get; set; } = new List<Permission>();
}