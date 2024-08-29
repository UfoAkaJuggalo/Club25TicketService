using Club25_Domain.Aggregates.ClientAggregate.Entities;
using Club25_Domain.Aggregates.UserAggregate.Entities;
using Club25_Domain.Common.Entities;

namespace Club25_Domain.Aggregates.UserAggregate;

public class User : Person
{
	public int Id { get; set; }

	public int IdPerson { get; set; }

	public int IdGroup { get; set; }

	public string Password { get; set; } = null!;

	public virtual UserGroup IdGroupNavigation { get; set; } = null!;

	public virtual PersonObsolete IdPersonNavigation { get; set; } = null!;
}