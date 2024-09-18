namespace Club25_Domain.Common.Entities;

public abstract record Organization
{
	public int Id { get; init; }
	public required string Name { get; init; }
}