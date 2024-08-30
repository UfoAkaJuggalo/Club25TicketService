using Club25_Domain.Aggregates.BookingAgencyAggregate.ValueObjects;
using Club25_Domain.Common.Entities;

namespace Club25_Domain.Aggregates.BookingAgencyAggregate.Entities;

public sealed class Band
{
	public int Id { get; set; }
	public required string Name { get; set; }
	public BookingAgencyPriceVO? PriceMin { get; set; }
	public BookingAgencyPriceVO? PriceMax { get; set; }
	public BookingAgency BookingAgency { get; set; } = null!; //move to m2m
	public int AgencyId { get; set; }
	public ICollection<Booker> Bookers { get; set; } = new List<Booker>();
	public ICollection<BandDescription> Descriptions { get; set; } = new List<BandDescription>();
	public ICollection<Artist> Members { get; set; } = new List<Artist>();
	public ICollection<Link> Links { get; set; } = new List<Link>();
	public ICollection<Tag> Tags { get; set; } = new List<Tag>();
}