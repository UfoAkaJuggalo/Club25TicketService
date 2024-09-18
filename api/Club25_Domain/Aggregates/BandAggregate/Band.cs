using Club25_Domain.Aggregates.BandAggregate.Entities;
using Club25_Domain.Aggregates.BookingAgencyAggregate.Entities;
using Club25_Domain.Aggregates.EventAggregate.Entities;
using Club25_Domain.Common.Entities;

namespace Club25_Domain.Aggregates.BandAggregate;

public sealed record Band
{
	public int Id { get; init; }
	public required string Name { get; init; }
	public ICollection<BookingAgencyBand> Bookers { get; init; } = new List<BookingAgencyBand>();
	public ICollection<BandDescription> Descriptions { get; init; } = new List<BandDescription>();
	public ICollection<Artist> Members { get; init; } = new List<Artist>();
	public ICollection<Link> Links { get; init; } = new List<Link>();
	public ICollection<Tag> Tags { get; init; } = new List<Tag>();
	public ICollection<LineupEntry> LineupEntries { get; set; } = new List<LineupEntry>();
}