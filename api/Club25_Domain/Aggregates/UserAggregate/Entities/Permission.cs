namespace Club25_Domain.Aggregates.UserAggregate.Entities;

public class Permission
{
	public int Id { get; set; }

	public string Name { get; set; } = null!;

	public string? Description { get; set; }
}