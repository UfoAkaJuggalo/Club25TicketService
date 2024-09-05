using Club25_Domain.Aggregates.SponsorAggregate;

namespace Club25_Domain.Aggregates.EventAggregate.Entities;

public class EventSponsor
{
	public int IdSponsor { get; init; }

	public int IdEvent { get; init; }

	public int? IdPrice { get; init; }

	public virtual Event IdEventNavigation { get; init; } = null!;

	public virtual Price? IdPriceNavigation { get; init; }

	public virtual Sponsor IdSponsorNavigation { get; init; } = null!;
}