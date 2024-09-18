namespace Club25_Domain.Aggregates.VenueAggregate.Entities;

public sealed record Seat
{
	public int Id { get; init; }
	public string Number { get; init; } = null!;
	public int PlanX { get; init; }
	public int PlanY { get; init; }
	public int Size { get; init; }
	public Sector Sector { get; init; }
	public int SectorId { get; init; }
}