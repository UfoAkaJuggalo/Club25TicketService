using Club25_Domain.Agregates.AgencyAgregate.Entities;
using Club25_Domain.Agregates.AgencyAgregate.ValueObjects;

namespace Club25_Domain.Agregates.AgencyAgregate;

public sealed class Agency
{
	public int Id { get; init; }
	public required string Name { get; init; }
	public required ContactVO Contact { get; init; }
	public ICollection<Band> Bands { get; init; } = new List<Band>();
	public ICollection<Agent> Agents { get; set; } = new List<Agent>();
}