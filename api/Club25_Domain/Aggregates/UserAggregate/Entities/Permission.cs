namespace Club25_Domain.Aggregates.UserAggregate.Entities;

public sealed class Permission
{
	public int Id { get; init; }
	public string Name { get; init; } = null!;
	public string? Description { get; init; }
}