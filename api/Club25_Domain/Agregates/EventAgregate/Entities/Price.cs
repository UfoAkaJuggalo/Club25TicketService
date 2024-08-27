using Club25_Domain.Agregates.AgencyAgregate.Entities;
using Club25_Domain.Agregates.TicketPoolAgregate;
using Club25_Domain.Agregates.VenueAgregate.Entities;

namespace Club25_Domain.Agregates.EventAgregate.Entities;

public class Price
{
	public int Id { get; set; }

	public int Amount { get; set; }

	public int IdCurrency { get; set; }

	public virtual ICollection<Artist> ArtistIdPriceMaxNavigations { get; set; } = new List<Artist>();

	public virtual ICollection<Artist> ArtistIdPriceMinNavigations { get; set; } = new List<Artist>();

	public virtual Currency IdCurrencyNavigation { get; set; } = null!;

	public virtual ICollection<Stage> StageIdPriceMaxNavigations { get; set; } = new List<Stage>();

	public virtual ICollection<Stage> StageIdPriceMinNavigations { get; set; } = new List<Stage>();

	public virtual ICollection<TicketPool> TicketPools { get; set; } = new List<TicketPool>();
}