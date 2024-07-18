using Club25_Domain.Agregates.EventAgregate.Entities;

namespace Club25_Domain.Agregates.VenueAgregate.Entities;

public partial class Stage
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? MinCapacity { get; set; }

    public int? MaxCapacity { get; set; }

    public int IdVenue { get; set; }

    public int? IdPriceMin { get; set; }

    public int? IdPriceMax { get; set; }

    public virtual Price? IdPriceMaxNavigation { get; set; }

    public virtual Price? IdPriceMinNavigation { get; set; }

    public virtual Venue IdVenueNavigation { get; set; } = null!;
}
