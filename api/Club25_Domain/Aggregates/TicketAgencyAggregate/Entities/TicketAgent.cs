using Club25_Domain.Aggregates.BookingAgencyAggregate;
using Club25_Domain.Aggregates.TicketAgencyAggregate.ValueObjects;
using Club25_Domain.Common.Entities;

namespace Club25_Domain.Aggregates.TicketAgencyAggregate.Entities;

public sealed class TicketAgent : Person
{
	public required TicketAgencyContactVO Contact { get; init; }
	public required TicketAgency TicketAgency { get; init; }
	public required int TicketAgencyId { get; init; }
	public ICollection<BookingAgency> PromoterAgencies { get; } = new List<BookingAgency>();
}