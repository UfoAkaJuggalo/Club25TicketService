using Club25_Domain.Aggregates.EventAggregate;
using Club25_Domain.Aggregates.TicketAgencyAggregate;
using Club25_Domain.Aggregates.TicketAgencyAggregate.Entities;
using Club25_Domain.Aggregates.TicketPoolAggregate.Entities;
using Club25_Domain.Aggregates.TicketPoolAggregate.Enums;
using Club25_Domain.Aggregates.TicketPoolAggregate.ValueObjects;

namespace Club25_Domain.Aggregates.TicketPoolAggregate;

public sealed class TicketPool
{
	public int Id { get; init; }
	public string Name { get; set; }
	public DateTime? DateStart { get; init; }
	public DateTime? DateEnd { get; init; }
	public decimal? Profit { get; init; }
	public DateTime? EventStart { get; set; }
	public DateTime? EventEnd { get; set; }
	public TicketType TicketType { get; set; }
	public TicketPriceVO TicketPrice { get; set; }
	public TicketAgency TicketAgency { get; set; }
	public Event Event { get; set; }
	public int TicketAgencyId { get; set; }
	public int EventId { get; set; }
	public ICollection<TicketMediaType> MediaTypes { get; set; } = new List<TicketMediaType>();
	public ICollection<Discount> AvailableDiscounts { get; set; } = new List<Discount>();
	public ICollection<Ticket> Tickets { get; init; } = new List<Ticket>();
	public ICollection<TicketDescription> Descriptions { get; set; } = new List<TicketDescription>();
	public ICollection<TicketAgent> TicketAgents { get; set; } = new List<TicketAgent>();
}