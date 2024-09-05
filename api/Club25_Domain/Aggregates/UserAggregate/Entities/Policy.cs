namespace Club25_Domain.Aggregates.UserAggregate.Entities;

public class Policy
{
	public int IdUserGroup { get; init; }

	public int IdPermission { get; init; }

	public virtual Permission IdPermissionNavigation { get; init; } = null!;

	public virtual UserGroup IdUserGroupNavigation { get; init; } = null!;
}