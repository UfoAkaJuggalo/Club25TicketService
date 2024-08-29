using Club25_Domain.Agregates.EventAgregate;
using Club25_Domain.Agregates.EventAgregate.Entities;
using Club25_Domain.Agregates.TicketPoolAgregate.Entities;

namespace Club25_Domain.Agregates.TicketPoolAgregate;

public partial class TicketPool
{
    public int Id { get; set; }

    public int IdTicketType { get; set; }

    public int IdTicketMedia { get; set; }

    public int IdEvent { get; set; }

    public int IdVendor { get; set; }

    public int IdPrice { get; set; }

    public int Amount { get; set; }

    public DateTime? DateStart { get; set; }

    public DateTime DateEnd { get; set; }

    public decimal? Profit { get; set; }

    public virtual Event IdEventNavigation { get; set; } = null!;

    public virtual Price IdPriceNavigation { get; set; } = null!;

    public virtual TicketMediaType IdTicketMediaNavigation { get; set; } = null!;

    public virtual TicketType IdTicketTypeNavigation { get; set; } = null!;

    public virtual Vendor IdVendorNavigation { get; set; } = null!;

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
