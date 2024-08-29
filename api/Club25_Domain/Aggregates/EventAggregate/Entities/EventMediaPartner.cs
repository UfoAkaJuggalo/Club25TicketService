using Club25_Domain.Aggregates.SponsorAggregate;

namespace Club25_Domain.Aggregates.EventAggregate.Entities;

public class EventMediaPartner
{
	public int IdSponsor { get; set; }

	public int IdEvent { get; set; }

	public int? Price { get; set; }

	public string? Description { get; set; }

	public virtual Event IdEventNavigation { get; set; } = null!;

	public virtual Sponsor IdSponsorNavigation { get; set; } = null!;

	public virtual Price? PriceNavigation { get; set; }
}