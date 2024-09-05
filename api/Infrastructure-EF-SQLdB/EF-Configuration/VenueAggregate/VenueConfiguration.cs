using Club25_Domain.Aggregates.VenueAggregate;
using Club25_Domain.Common.VObase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration.VenueAggregate;

public sealed class VenueConfiguration : IEntityTypeConfiguration<Venue>
{
	public void Configure(EntityTypeBuilder<Venue> builder)
	{
		builder.ToTable(nameof(Venue));

		builder.HasMany(m => m.Stages)
		       .WithOne(m => m.Venue)
		       .HasForeignKey(f => f.VenueId);

		builder.HasMany(m => m.StageManagers)
		       .WithOne(m => m.Venue)
		       .HasForeignKey(f => f.VenueId);

		builder.HasMany(m => m.Events)
		       .WithOne(m => m.Venue)
		       .HasForeignKey(f => f.VenueId);

		builder.HasMany(m => m.Links)
		       .WithOne();

		builder.Property(e => e.GpsLatitude)
		       .HasPrecision(18, 15)
		       .HasColumnName(nameof(Venue.GpsLatitude).ToLower());
		builder.Property(e => e.GpsLongitude)
		       .HasPrecision(18, 15)
		       .HasColumnName(nameof(Venue.GpsLongitude).ToLower());

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