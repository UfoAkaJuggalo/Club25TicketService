namespace Club25_Domain.Agregates.TicketPoolAgregate.Entities;

public partial class TicketType
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<TicketPool> TicketPools { get; set; } = new List<TicketPool>();
}
