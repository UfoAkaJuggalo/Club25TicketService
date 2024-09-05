using Club25_Domain.Aggregates.SponsorAggregate;

namespace Club25_Domain.Aggregates.EventAggregate.Entities;

public class EventMediaPartner
{
	public int IdSponsor { get; init; }

	public int IdEvent { get; init; }

	public int? Price { get; init; }

	public string? Description { get; init; }

	public virtual Event IdEventNavigation { get; init; } = null!;

	public virtual Sponsor IdSponsorNavigation { get; init; } = null!;

	public virtual Price? PriceNavigation { get; init; }
}