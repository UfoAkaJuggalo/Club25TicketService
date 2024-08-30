using Club25_Domain.Common.Entities;

namespace Club25_Domain.Aggregates.BookingAgencyAggregate.Entities;

public sealed class BandDescription : Description
{
	public int BandId { get; set; }
	public Band Band { get; set; }
}