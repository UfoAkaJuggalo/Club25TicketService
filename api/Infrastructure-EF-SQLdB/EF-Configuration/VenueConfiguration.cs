using Club25_Domain.Aggregates.VenueAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration;

public sealed class VenueConfiguration : IEntityTypeConfiguration<Venue>
{
	public void Configure(EntityTypeBuilder<Venue> builder)
	{
		builder.ToTable("Venue");

		builder.Property(e => e.Id)
		       .ValueGeneratedNever()
		       .HasColumnName("id");
		builder.Property(e => e.Adres)
		       .HasMaxLength(50)
		       .HasColumnName("adres");
		builder.Property(e => e.City)
		       .HasMaxLength(50)
		       .HasColumnName("city");
		builder.Property(e => e.Email)
		       .HasMaxLength(25)
		       .HasColumnName("email");
		builder.Property(e => e.GpsLatitude)
		       .HasColumnType("decimal(18, 0)")
		       .HasColumnName("gps_latitude");
		builder.Property(e => e.GpsLongitude)
		       .HasColumnType("decimal(18, 0)")
		       .HasColumnName("gps_longitude");
		builder.Property(e => e.Name)
		       .HasMaxLength(50)
		       .HasColumnName("name");
		builder.Property(e => e.Phone)
		       .HasMaxLength(25)
		       .HasColumnName("phone");
		builder.Property(e => e.Www)
		       .HasMaxLength(25)
		       .HasColumnName("www");
	}
}