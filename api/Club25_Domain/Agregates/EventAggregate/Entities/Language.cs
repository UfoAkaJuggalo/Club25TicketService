namespace Club25_Domain.Agregates.EventAgregate.Entities;

public partial class Language
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string ShortName { get; set; } = null!;

    public virtual ICollection<Culture> Cultures { get; set; } = new List<Culture>();
}
