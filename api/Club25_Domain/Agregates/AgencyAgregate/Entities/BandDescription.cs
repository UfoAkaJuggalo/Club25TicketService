using Club25_Domain.CommonEntities;

namespace Club25_Domain.Agregates.AgencyAgregate.Entities;

public sealed class BandDescription : Description
{
	public int BandId { get; set; }
	public Band Band { get; set; }
}