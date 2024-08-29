namespace Club25_Domain.Agregates.EventAgregate.Entities;

public partial class Culture
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string ShortName { get; set; } = null!;

    public int IdCurrency { get; set; }

    public int IdLanguage { get; set; }

    public virtual Currency IdCurrencyNavigation { get; set; } = null!;

    public virtual Language IdLanguageNavigation { get; set; } = null!;
}
