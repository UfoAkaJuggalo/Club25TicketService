using Club25_Domain.Aggregates.BookingAgencyAggregate;
using Club25_Domain.Common.VObase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration.Club25Context.BookingAgencyAggregate;

public sealed class BookingAgencyConfiguration : IEntityTypeConfiguration<BookingAgency>
{
	public void Configure(EntityTypeBuilder<BookingAgency> builder)
	{
		builder.ToTable(nameof(BookingAgency));

		builder.HasMany(m => m.Bands)
		       .WithOne(o => o.BookingAgency)
		       .HasForeignKey(k => k.BookingAgencyId)
		       .IsRequired();

		builder.HasMany(m => m.Bookers)
		       .WithOne(o => o.BookingAgency)
		       .HasForeignKey(f => f.BookingAgencyId)
		       .IsRequired()
		       .OnDelete(DeleteBehavior.ClientSetNull);

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