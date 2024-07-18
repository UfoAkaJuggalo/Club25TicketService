using Club25_Domain.Agregates.EventAgregate.Entities;

namespace Club25_Domain.Agregates.BandAgregate.Entities;

public partial class ArtistDescription
{
    public int IdArtist { get; set; }

    public int IdLanguage { get; set; }

    public string Description { get; set; } = null!;

    public virtual Artist IdArtistNavigation { get; set; } = null!;

    public virtual Language IdLanguageNavigation { get; set; } = null!;
}
