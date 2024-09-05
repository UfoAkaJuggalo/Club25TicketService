using Club25_Domain.Aggregates.UserAggregate;

namespace Club25_Domain.Aggregates.ClientAggregate.Entities;

public class PersonObsolete
{
	public int Id { get; init; }

	public string Name { get; init; } = null!;

	public string Surname { get; init; } = null!;

	public string Email { get; init; } = null!;

	public virtual ICollection<Client> Clients { get; init; } = new List<Client>();

	public virtual ICollection<User> Users { get; init; } = new List<User>();
}