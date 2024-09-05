using Club25_Domain.Aggregates.BandAggregate.Entities;
using Club25_Domain.Aggregates.TicketPoolAggregate;
using Club25_Domain.Aggregates.VenueAggregate.Entities;

namespace Club25_Domain.Aggregates.EventAggregate.Entities;

public class Price
{
	public int Id { get; init; }

	public int Amount { get; init; }

	public int IdCurrency { get; init; }

	public virtual ICollection<Artist> ArtistIdPriceMaxNavigations { get; init; } = new List<Artist>();

	public virtual ICollection<Artist> ArtistIdPriceMinNavigations { get; init; } = new List<Artist>();

	public virtual Currency IdCurrencyNavigation { get; init; } = null!;

	public virtual ICollection<Stage> StageIdPriceMaxNavigations { get; init; } = new List<Stage>();

	public virtual ICollection<Stage> StageIdPriceMinNavigations { get; init; } = new List<Stage>();

	public virtual ICollection<TicketPool> TicketPools { get; init; } = new List<TicketPool>();
}