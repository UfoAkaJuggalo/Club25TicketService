using Club25_Domain.Agregates.BandAgregate.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration;

public sealed class ArtistConfiguration : IEntityTypeConfiguration<Artist>
{
	public void Configure(EntityTypeBuilder<Artist> builder)
	{
		builder.ToTable(nameof(Artist));

		builder.Property(e => e.Id)
		       .ValueGeneratedNever()
		       .HasColumnName("id");
		builder.Property(e => e.BookingInfo)
		       .HasMaxLength(250)
		       .HasColumnName("booking_info");
		builder.Property(e => e.BookingMail)
		       .HasMaxLength(25)
		       .HasColumnName("booking_mail");
		builder.Property(e => e.BookingPhone)
		       .HasMaxLength(15)
		       .HasColumnName("booking_phone");
		builder.Property(e => e.IdPriceMax).HasColumnName("idPrice_max");
		builder.Property(e => e.IdPriceMin).HasColumnName("idPrice_min");
		builder.Property(e => e.Mixcloud)
		       .HasMaxLength(25)
		       .HasColumnName("mixcloud");
		builder.Property(e => e.Name)
		       .HasMaxLength(25)
		       .HasColumnName("name");
		builder.Property(e => e.Photo).HasColumnName("photo");
		builder.Property(e => e.Soundcloud)
		       .HasMaxLength(25)
		       .HasColumnName("soundcloud");
		builder.Property(e => e.Www)
		       .HasMaxLength(20)
		       .HasColumnName("www");
		builder.Property(e => e.Youtube)
		       .HasMaxLength(25)
		       .HasColumnName("youtube");

		builder.HasOne(d => d.IdPriceMaxNavigation).WithMany(p => p.ArtistIdPriceMaxNavigations)
		       .HasForeignKey(d => d.IdPriceMax)
		       .HasConstraintName("FK_Artist_Price1");

		builder.HasOne(d => d.IdPriceMinNavigation).WithMany(p => p.ArtistIdPriceMinNavigations)
		       .HasForeignKey(d => d.IdPriceMin)
		       .HasConstraintName("FK_Artist_Price");
	}
}