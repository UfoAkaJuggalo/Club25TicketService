using Club25_Domain.Aggregates.BandAggregate;
using Club25_Domain.Aggregates.BookingAgencyAggregate.ValueObjects;

namespace Club25_Domain.Aggregates.BookingAgencyAggregate.Entities;

public sealed class BookingAgencyBand
{
	public int Id { get; init; }
	public BookingAgencyPriceVO? PriceMin { get; init; }
	public BookingAgencyPriceVO? PriceMax { get; init; }
	public Band Band { get; init; }
	public int BandId { get; init; }
	public BookingAgency BookingAgency { get; init; }
	public int BookingAgencyId { get; init; }
	public ICollection<Booker> Bookers { get; init; } = new List<Booker>();
}