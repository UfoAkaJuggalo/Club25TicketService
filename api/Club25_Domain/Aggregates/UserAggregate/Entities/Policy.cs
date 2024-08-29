namespace Club25_Domain.Aggregates.UserAggregate.Entities;

public class Policy
{
	public int IdUserGroup { get; set; }

	public int IdPermission { get; set; }

	public virtual Permission IdPermissionNavigation { get; set; } = null!;

	public virtual UserGroup IdUserGroupNavigation { get; set; } = null!;
}