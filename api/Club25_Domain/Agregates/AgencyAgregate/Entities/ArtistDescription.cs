using Club25_Domain.CommonEntities;

namespace Club25_Domain.Agregates.AgencyAgregate.Entities;

public sealed class ArtistDescription : Description
{
	public int ArtistId { get; set; }
	public Artist Artist { get; set; }
}