using Club25_Domain.Aggregates.SponsorAggregate.Entities;
using Club25_Domain.Aggregates.SponsorAggregate.Enums;
using Club25_Domain.Common.VObase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration.Club25Context.SponsorAggregate;

public sealed class SponsorContractConfiguration : IEntityTypeConfiguration<SponsorContract>
{
	public void Configure(EntityTypeBuilder<SponsorContract> builder)
	{
		builder.ToTable(nameof(SponsorContract))
		       .HasKey(k => k.Id);

		builder.HasDiscriminator<string>(nameof(SponsorContract.ContractType).ToLower())
		       .HasValue<SponsorVenueContract>(ContractType.venue.ToString())
		       .HasValue<SponsorEventContract>(ContractType.single_event.ToString())
		       .HasValue<SponsorEventStageContract>(ContractType.event_stage.ToString());

		builder.HasMany(m => m.Descriptions)
		       .WithOne(o => o.Contract)
		       .HasForeignKey(f => f.SponsorContractId);

		builder.HasMany(m => m.Representatives)
		       .WithMany();

		var columnOrder = 0;

		builder.Property(p => p.Id)
		       .HasColumnName(nameof(SponsorContract.Id).ToLower())
		       .HasColumnOrder(columnOrder++)
		       .UseIdentityColumn();

		builder.ComplexProperty(o => o.Price, navigationBuilder =>
		{
			navigationBuilder.IsRequired();
			navigationBuilder.Property(p => p.Price)
			                 .HasColumnName(nameof(PriceVO.Price).ToLower())
			                 .HasPrecision(10, 2);
			navigationBuilder.Property(p => p.Currency)
			                 .HasColumnName(nameof(PriceVO.Currency).ToLower())
			                 .HasConversion<string>();
		});

		builder.Property(p => p.SponsorType)
		       .HasColumnName(nameof(SponsorContract.SponsorType).ToLower())
		       .HasColumnOrder(columnOrder++)
		       .HasConversion<string>();

		builder.Property(p => p.Start)
		       .HasColumnName(nameof(SponsorContract.Start).ToLower())
		       .HasColumnOrder(columnOrder++)
		       .HasConversion<DateOnly>();

		builder.Property(p => p.End)
		       .HasColumnName(nameof(SponsorContract.End).ToLower())
		       .HasColumnOrder(columnOrder++)
		       .HasConversion<DateOnly>();

		builder.Property(p => p.ContractType)
		       .HasColumnName(nameof(SponsorContract.ContractType).ToLower())
		       .HasColumnOrder(columnOrder)
		       .HasMaxLength(16);
	}
}