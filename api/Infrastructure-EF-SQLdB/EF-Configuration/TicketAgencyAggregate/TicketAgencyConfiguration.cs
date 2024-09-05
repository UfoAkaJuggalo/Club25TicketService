using Club25_Domain.Aggregates.TicketAgencyAggregate;
using Club25_Domain.Common.VObase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration.TicketAgencyAggregate;

public sealed class TicketAgencyConfiguration : IEntityTypeConfiguration<TicketAgency>
{
	public void Configure(EntityTypeBuilder<TicketAgency> builder)
	{
		builder.ToTable(nameof(TicketAgency));

		builder.HasMany(m => m.TicketAgents)
		       .WithOne(o => o.TicketAgency)
		       .HasForeignKey(o => o.TicketAgencyId)
		       .OnDelete(DeleteBehavior.Restrict);

		builder.HasMany(m => m.PromoterAgencies)
		       .WithMany();

		builder.OwnsOne(o => o.Contact, navigationBuilder =>
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