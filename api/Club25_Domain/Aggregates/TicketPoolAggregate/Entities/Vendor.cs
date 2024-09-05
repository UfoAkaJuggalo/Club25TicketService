namespace Club25_Domain.Aggregates.TicketPoolAggregate.Entities;

public class Vendor
{
	public int Id { get; init; }

	public string Name { get; init; } = null!;

	public string? Adres { get; init; }

	public string? City { get; init; }

	public string? Email { get; init; }

	public string? Phone { get; init; }

	public string Www { get; init; } = null!;

	public string Hash { get; init; } = null!;

	public decimal? AverageProfit { get; init; }

	public virtual ICollection<TicketPool> TicketPools { get; init; } = new List<TicketPool>();
}