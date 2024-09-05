using Club25_Domain.Aggregates.VenueAggregate.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration.VenueAggregate;

public sealed class StageToStageManagerConfiguration : IEntityTypeConfiguration<StageToStageManager>
{
	public void Configure(EntityTypeBuilder<StageToStageManager> builder)
	{
		builder.ToTable(nameof(StageToStageManager))
		       .HasKey(k => new
		       {
			       k.StageId,
			       k.StageManagerId
		       });
	}
}