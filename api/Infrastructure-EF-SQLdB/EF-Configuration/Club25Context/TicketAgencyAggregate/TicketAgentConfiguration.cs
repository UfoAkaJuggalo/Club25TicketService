using Club25_Domain.Aggregates.TicketAgencyAggregate.Entities;
using Club25_Domain.Common.VObase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration.Club25Context.TicketAgencyAggregate;

public sealed class TicketAgentConfiguration : IEntityTypeConfiguration<TicketAgent>
{
	public void Configure(EntityTypeBuilder<TicketAgent> builder)
	{
		builder.ToTable(nameof(TicketAgent));

		builder.HasMany(m => m.PromoterAgencies)
		       .WithMany(m => m.Accountants);

		builder.ComplexProperty(o => o.Contact, navigationBuilder =>
		{
			navigationBuilder.Property(p => p.Email)
			                 .IsRequired()
			                 .HasColumnName(nameof(ContactVO.Email).ToLower())
			                 .HasMaxLength(32);
			navigationBuilder.Property(p => p.Phone)
			                 .HasColumnName(nameof(ContactVO.Phone).ToLower())
			                 .HasMaxLength(16);
			navigationBuilder.Property(p => p.Country)
			                 .HasColumnName(nameof(ContactVO.Country).ToLower())
			                 .HasMaxLength(64);
			navigationBuilder.Property(p => p.City)
			                 .HasColumnName(nameof(ContactVO.City).ToLower())
			                 .HasMaxLength(64);
			navigationBuilder.Property(p => p.Address)
			                 .HasColumnName(nameof(ContactVO.Address).ToLower())
			                 .HasMaxLength(100);
		});
	}
}