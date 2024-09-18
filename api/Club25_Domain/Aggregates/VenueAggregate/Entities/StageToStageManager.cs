namespace Club25_Domain.Aggregates.VenueAggregate.Entities;

public sealed record StageToStageManager
{
	public Stage Stage { get; set; }
	public int StageId { get; set; }

	public StageManager StageManager { get; set; }
	public int StageManagerId { get; set; }
}