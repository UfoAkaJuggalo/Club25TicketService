using Club25_Domain.Agregates.ClientAgregate.Entities;
using Club25_Domain.Agregates.TicketPoolAgregate.Entities;

namespace Club25_Domain.Agregates.ClientAgregate;

public partial class Client
{
    public int Id { get; set; }

    public int IdPerson { get; set; }

    public string? Phone { get; set; }

    public virtual Person IdPersonNavigation { get; set; } = null!;

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
