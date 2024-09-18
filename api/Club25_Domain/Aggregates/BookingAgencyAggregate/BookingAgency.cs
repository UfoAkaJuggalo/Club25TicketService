using Club25_Domain.Aggregates.BookingAgencyAggregate.Entities;
using Club25_Domain.Aggregates.BookingAgencyAggregate.ValueObjects;
using Club25_Domain.Common.Entities;

namespace Club25_Domain.Aggregates.BookingAgencyAggregate;

public sealed record BookingAgency : Organization
{
	public required BookingAgencyContactVO Contact { get; init; }
	public ICollection<BookingAgencyBand> Bands { get; init; } = new List<BookingAgencyBand>();
	public ICollection<Booker> Bookers { get; init; } = new List<Booker>();
}