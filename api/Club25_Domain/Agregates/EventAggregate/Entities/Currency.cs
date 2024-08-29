namespace Club25_Domain.Agregates.EventAgregate.Entities;

public partial class Currency
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Shortname { get; set; } = null!;

    public virtual ICollection<Culture> Cultures { get; set; } = new List<Culture>();

    public virtual ICollection<Price> Prices { get; set; } = new List<Price>();
}
