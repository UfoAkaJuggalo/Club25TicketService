namespace Club25_Domain.Agregates.EventAgregate.Entities;

public partial class EventDescription
{
    public int IdEvent { get; set; }

    public int IdLanguage { get; set; }

    public string Description { get; set; } = null!;

    public virtual Event IdEventNavigation { get; set; } = null!;

    public virtual Language IdLanguageNavigation { get; set; } = null!;
}
