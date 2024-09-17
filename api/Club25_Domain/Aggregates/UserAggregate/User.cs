using Club25_Domain.Aggregates.UserAggregate.Entities;
using Club25_Domain.Common.Entities;

namespace Club25_Domain.Aggregates.UserAggregate;

public sealed class User : UserAccount
{
	//public UserConfigVO UserConfig { get; set; } = new();
	public ICollection<UserGroup> UserGroups { get; set; }
	public ICollection<Permission> Permissions { get; set; }
}