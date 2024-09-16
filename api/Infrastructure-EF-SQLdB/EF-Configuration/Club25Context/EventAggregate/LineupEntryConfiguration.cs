using Club25_Domain.Aggregates.EventAggregate.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure_EF_SQLdB.EF_Configuration.Club25Context.EventAggregate;

public sealed class LineupEntryConfiguration : IEntityTypeConfiguration<LineupEntry>
{
	public void Configure(EntityTypeBuilder<LineupEntry> builder)
	{
		builder.ToTable(nameof(LineupEntry))
		       .HasKey(e => e.Id);

		var columnOrder = 0;

		builder.Property(p => p.Id)
		       .HasColumnOrder(columnOrder++)
		       .HasColumnName(nameof(LineupEntry.Id).ToLower())
		       .UseIdentityColumn();

		builder.Property(p => p.StartTime)
		       .HasColumnOrder(columnOrder++)
		       .HasColumnName(nameof(LineupEntry.StartTime).ToLower())
		       .HasConversion(new DateTimeToStringConverter());

		builder.Property(p => p.EndTime)
		       .HasColumnOrder(columnOrder++)
		       .HasColumnName(nameof(LineupEntry.EndTime).ToLower())
		       .HasConversion(new DateTimeToStringConverter());
	}
}