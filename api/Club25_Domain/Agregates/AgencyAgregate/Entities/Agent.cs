using Club25_Domain.Agregates.AgencyAgregate.ValueObjects;

namespace Club25_Domain.Agregates.AgencyAgregate.Entities;

public sealed class Agent
{
	public int Id { get; set; }
	public Agency Agency { get; set; }
	public required string Name { get; set; }
	public required string Surname { get; set; }
	public required ContactVO Contact { get; set; }
	public ICollection<Band>? Bands { get; set; }
	public int AgencyId { get; set; }
}