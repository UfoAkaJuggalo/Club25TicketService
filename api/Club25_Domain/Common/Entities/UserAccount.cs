namespace Club25_Domain.Common.Entities;

public abstract class UserAccount
{
	public Guid Id { get; set; }
	public required string Login { get; set; }
	public required string Name { get; init; }
	public required string Surname { get; init; }
	public required string Email { get; set; }
	public required string Pass { get; set; }
	public required string Salt { get; set; }
	public decimal ConfigVersion { get; set; } = decimal.Zero;
}