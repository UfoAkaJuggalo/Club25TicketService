using Club25_Domain.Agregates.PromoterAgencyAgregate.Entities;

namespace Club25_Domain.Agregates.EventAgregate.Entities;

public class EventArtist
{
	public int IdEvent { get; set; }

	public int IdArtist { get; set; }

	public virtual Artist IdArtistNavigation { get; set; } = null!;

	public virtual Event IdEventNavigation { get; set; } = null!;
}