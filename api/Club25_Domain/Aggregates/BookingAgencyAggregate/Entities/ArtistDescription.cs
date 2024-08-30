using Club25_Domain.Common.Entities;

namespace Club25_Domain.Aggregates.BookingAgencyAggregate.Entities;

public sealed class ArtistDescription : Description
{
	public int ArtistId { get; set; }
	public Artist Artist { get; set; }
}