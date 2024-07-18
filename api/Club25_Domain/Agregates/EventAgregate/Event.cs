using Club25_Domain.Agregates.TicketPoolAgregate;
using Club25_Domain.Agregates.VenueAgregate;

namespace Club25_Domain.Agregates.EventAgregate;

public partial class Event
{
    public int Id { get; set; }

    public DateTime Date { get; set; }

    public int IdVenue { get; set; }

    public string? FbEvent { get; set; }

    public byte[] Flyer { get; set; } = null!;

    public virtual Venue IdVenueNavigation { get; set; } = null!;

    public virtual ICollection<TicketPool> TicketPools { get; set; } = new List<TicketPool>();
}
