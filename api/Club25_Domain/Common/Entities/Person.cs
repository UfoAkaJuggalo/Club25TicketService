namespace Club25_Domain.Common.Entities;

public abstract record Person
{
	public int Id { get; init; }
	public required string Name { get; init; }
	public required string Surname { get; init; }
}