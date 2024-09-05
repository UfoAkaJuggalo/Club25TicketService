using Club25_Domain.Aggregates.BandAggregate.Entities;
using Club25_Domain.Aggregates.VenueAggregate.Entities;

namespace Club25_Domain.Aggregates.EventAggregate.Entities;

public class Lineup
{
	public int IdEvent { get; init; }

	public int? IdStage { get; init; }

	public int? IdArtist { get; init; }

	public DateTime StartTime { get; init; }

	public DateTime StopTime { get; init; }

	public string? Description { get; init; }

	public virtual Artist? IdArtistNavigation { get; init; }

	public virtual Event IdEventNavigation { get; init; } = null!;

	public virtual Stage? IdStageNavigation { get; init; }
}