using Club25_Domain.Aggregates.BandAggregate.Entities;

namespace Club25_Domain.Aggregates.EventAggregate.Entities;

public class EventArtist
{
	public int IdEvent { get; init; }

	public int IdArtist { get; init; }

	public virtual Artist IdArtistNavigation { get; init; } = null!;

	public virtual Event IdEventNavigation { get; init; } = null!;
}