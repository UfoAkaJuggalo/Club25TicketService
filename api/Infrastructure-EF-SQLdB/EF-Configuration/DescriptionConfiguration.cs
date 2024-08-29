using Club25_Domain.Aggregates.PromoterAgencyAggregate.Entities;
using Club25_Domain.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration;

public sealed class DescriptionConfiguration : IEntityTypeConfiguration<Description>
{
	public void Configure(EntityTypeBuilder<Description> builder)
	{
		var columnOrder = 0;
		builder.UseTpcMappingStrategy();

		builder.Property(p => p.Id)
		       .HasColumnName(nameof(BandDescription.Id).ToLower())
		       .HasColumnOrder(columnOrder++)
		       .UseIdentityColumn();

		builder.Property(e => e.DescriptionText)
		       .HasColumnName(nameof(BandDescription.DescriptionText).ToLower())
		       .HasColumnOrder(columnOrder++)
		       .HasMaxLength(2048);

		builder.Property(e => e.LanguageCode)
		       .HasColumnName(nameof(BandDescription).ToLower())
		       .HasColumnOrder(columnOrder++)
		       .HasConversion<string>();
	}
}