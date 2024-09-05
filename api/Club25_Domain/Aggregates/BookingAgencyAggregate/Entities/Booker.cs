using Club25_Domain.Aggregates.BookingAgencyAggregate.ValueObjects;
using Club25_Domain.Common.Entities;

namespace Club25_Domain.Aggregates.BookingAgencyAggregate.Entities;

public sealed class Booker : Person
{
	public required BookingAgency BookingAgency { get; init; }
	public required BookingAgencyContactVO Contact { get; init; }
	public required int BookingAgencyId { get; init; }
	public ICollection<BookingAgencyBand> Bands { get; } = new List<BookingAgencyBand>();
}