namespace Club25_Domain.Agregates.EventAgregate.Entities;

public partial class FeaturedEvent
{
    public int IdEvent { get; set; }

    public virtual Event IdEventNavigation { get; set; } = null!;
}
