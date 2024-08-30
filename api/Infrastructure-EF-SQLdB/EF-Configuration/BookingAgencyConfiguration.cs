using Club25_Domain.Aggregates.BookingAgencyAggregate;
using Club25_Domain.Common.VObase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration;

public sealed class BookingAgencyConfiguration : IEntityTypeConfiguration<BookingAgency>
{
	public void Configure(EntityTypeBuilder<BookingAgency> builder)
	{
		builder.ToTable(nameof(BookingAgency))
		       .HasKey(k => k.Id);

		var columnOrder = 0;

		builder.HasMany(m => m.Bands)
		       .WithOne(o => o.BookingAgency)
		       .HasForeignKey(k => k.AgencyId)
		       .IsRequired();

		builder.HasMany(m => m.Bookers)
		       .WithOne(o => o.BookingAgency)
		       .HasForeignKey(f => f.BookingAgencyId)
		       .IsRequired();

		builder.HasMany(m => m.Accountants)
		       .WithMany(m => m.PromoterAgencies)
		       .UsingEntity(j => j.ToTable("Accountants"));

		builder.Property(p => p.Id)
		       .HasColumnOrder(columnOrder++)
		       .HasColumnName(nameof(BookingAgency.Id).ToLower())
		       .UseIdentityColumn();

		builder.Property(p => p.Name)
		       .IsRequired()
		       .HasColumnOrder(columnOrder++)
		       .HasMaxLength(100)
		       .HasColumnName(nameof(BookingAgency.Name).ToLower());

		builder.OwnsOne(o => o.Contact, navigationBuilder =>
		{
			navigationBuilder.Property(p => p.Email)
			                 .IsRequired()
			                 .HasColumnName(nameof(ContactVO.Email).ToLower())
			                 .HasColumnOrder(columnOrder++)
			                 .HasMaxLength(32);
			navigationBuilder.Property(p => p.Phone)
			                 .HasColumnName(nameof(ContactVO.Phone).ToLower())
			                 .HasColumnOrder(columnOrder++)
			                 .HasMaxLength(16);
			navigationBuilder.Property(p => p.Country)
			                 .HasColumnName(nameof(ContactVO.Country).ToLower())
			                 .HasColumnOrder(columnOrder++)
			                 .HasMaxLength(64);
			navigationBuilder.Property(p => p.City)
			                 .HasColumnName(nameof(ContactVO.City).ToLower())
			                 .HasColumnOrder(columnOrder++)
			                 .HasMaxLength(64);
			navigationBuilder.Property(p => p.Address)
			                 .HasColumnName(nameof(ContactVO.Address).ToLower())
			                 .HasColumnOrder(columnOrder++)
			                 .HasMaxLength(100);
		});
	}
}