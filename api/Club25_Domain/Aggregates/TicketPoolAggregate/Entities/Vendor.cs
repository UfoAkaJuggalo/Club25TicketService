namespace Club25_Domain.Aggregates.TicketPoolAggregate.Entities;

public class Vendor
{
	public int Id { get; set; }

	public string Name { get; set; } = null!;

	public string? Adres { get; set; }

	public string? City { get; set; }

	public string? Email { get; set; }

	public string? Phone { get; set; }

	public string Www { get; set; } = null!;

	public string Hash { get; set; } = null!;

	public decimal? AverageProfit { get; set; }

	public virtual ICollection<TicketPool> TicketPools { get; set; } = new List<TicketPool>();
}