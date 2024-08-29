using Club25_Domain.Aggregates.EventAggregate;
using Club25_Domain.Aggregates.VenueAggregate.Entities;

namespace Club25_Domain.Aggregates.VenueAggregate;

public class Venue
{
	public int Id { get; set; }

	public string Name { get; set; } = null!;

	public string City { get; set; } = null!;

	public string Adres { get; set; } = null!;

	public string? Phone { get; set; }

	public string? Email { get; set; }

	public string? Www { get; set; }

	public decimal? GpsLatitude { get; set; }

	public decimal? GpsLongitude { get; set; }

	public virtual ICollection<Event> Events { get; set; } = new List<Event>();

	public virtual ICollection<Stage> Stages { get; set; } = new List<Stage>();
}