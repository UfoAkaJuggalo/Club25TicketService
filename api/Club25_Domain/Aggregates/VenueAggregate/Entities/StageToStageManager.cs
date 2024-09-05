namespace Club25_Domain.Aggregates.VenueAggregate.Entities;

public sealed class StageToStageManager
{
	public Stage Stage { get; set; }
	public int StageId { get; set; }

	public StageManager StageManager { get; set; }
	public int StageManagerId { get; set; }
}