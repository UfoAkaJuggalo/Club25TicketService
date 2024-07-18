using Club25_Domain.Agregates.EventAgregate.Entities;

namespace Club25_Domain.Agregates.BandAgregate.Entities;

public partial class Artist
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Www { get; set; }

    public string? Youtube { get; set; }

    public string? Soundcloud { get; set; }

    public string? Mixcloud { get; set; }

    public string? BookingMail { get; set; }

    public string? BookingPhone { get; set; }

    public string? BookingInfo { get; set; }

    public int? IdPriceMin { get; set; }

    public int? IdPriceMax { get; set; }

    public byte[] Photo { get; set; } = null!;

    public virtual Price? IdPriceMaxNavigation { get; set; }

    public virtual Price? IdPriceMinNavigation { get; set; }
}
