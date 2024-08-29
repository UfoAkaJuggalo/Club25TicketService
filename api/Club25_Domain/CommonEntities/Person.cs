namespace Club25_Domain.CommonEntities;

public abstract class Person
{
	public int Id { get; set; }
	public required string Name { get; set; }
	public required string Surname { get; set; }
}