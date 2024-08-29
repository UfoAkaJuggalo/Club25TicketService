using Club25_Domain.Aggregates.SponsorAggregate;

namespace Club25_Domain.Aggregates.EventAggregate.Entities;

public class EventSponsor
{
	public int IdSponsor { get; set; }

	public int IdEvent { get; set; }

	public int? IdPrice { get; set; }

	public virtual Event IdEventNavigation { get; set; } = null!;

	public virtual Price? IdPriceNavigation { get; set; }

	public virtual Sponsor IdSponsorNavigation { get; set; } = null!;
}