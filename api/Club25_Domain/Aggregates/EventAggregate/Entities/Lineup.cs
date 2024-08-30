using Club25_Domain.Aggregates.BookingAgencyAggregate.Entities;
using Club25_Domain.Aggregates.VenueAggregate.Entities;

namespace Club25_Domain.Aggregates.EventAggregate.Entities;

public class Lineup
{
	public int IdEvent { get; set; }

	public int? IdStage { get; set; }

	public int? IdArtist { get; set; }

	public DateTime StartTime { get; set; }

	public DateTime StopTime { get; set; }

	public string? Description { get; set; }

	public virtual Artist? IdArtistNavigation { get; set; }

	public virtual Event IdEventNavigation { get; set; } = null!;

	public virtual Stage? IdStageNavigation { get; set; }
}