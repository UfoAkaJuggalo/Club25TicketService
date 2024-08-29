using Club25_Domain.Agregates.EventAgregate.Entities;

namespace Club25_Domain.Agregates.SponsorAgregate.Entities;

public partial class MainSponsor
{
    public int IdSponsor { get; set; }

    public DateTime? DateStart { get; set; }

    public DateTime? DateEnd { get; set; }

    public int? IdPrice { get; set; }

    public string? Description { get; set; }

    public virtual Price? IdPriceNavigation { get; set; }

    public virtual Sponsor IdSponsorNavigation { get; set; } = null!;
}
