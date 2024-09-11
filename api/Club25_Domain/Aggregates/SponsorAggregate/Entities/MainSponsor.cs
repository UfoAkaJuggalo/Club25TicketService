namespace Club25_Domain.Aggregates.SponsorAggregate.Entities;

[Obsolete]
public class MainSponsor
{
	public int IdSponsor { get; init; }

	public DateTime? DateStart { get; init; }

	public DateTime? DateEnd { get; init; }

//	public int? IdPrice { get; init; }

	public string? Description { get; init; }

	//public virtual Price? IdPriceNavigation { get; init; }

	public virtual Sponsor IdSponsorNavigation { get; init; } = null!;
}