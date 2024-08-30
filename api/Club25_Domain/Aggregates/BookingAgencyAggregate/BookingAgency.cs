using Club25_Domain.Aggregates.BookingAgencyAggregate.Entities;
using Club25_Domain.Aggregates.BookingAgencyAggregate.ValueObjects;
using Club25_Domain.Aggregates.TicketAgencyAggregate.Entities;

namespace Club25_Domain.Aggregates.BookingAgencyAggregate;

public sealed class BookingAgency
{
	public int Id { get; init; }
	public required string Name { get; init; }
	public required BookingAgencyContactVO Contact { get; init; }
	public ICollection<Band> Bands { get; init; } = new List<Band>();
	public ICollection<Booker> Bookers { get; set; } = new List<Booker>();
	public ICollection<TicketAgent> Accountants { get; set; } = new List<TicketAgent>(); //to dla promotora
}