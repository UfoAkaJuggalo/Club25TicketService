using Club25_Domain.Aggregates.ClientAggregate.Entities;
using Club25_Domain.Aggregates.UserAggregate.Entities;
using Club25_Domain.Common.Entities;

namespace Club25_Domain.Aggregates.UserAggregate;

public class User : Person
{
	public int Id { get; init; }

	public int IdPerson { get; init; }

	public int IdGroup { get; init; }

	public string Password { get; init; } = null!;

	public virtual UserGroup IdGroupNavigation { get; init; } = null!;

	public virtual PersonObsolete IdPersonNavigation { get; init; } = null!;
}