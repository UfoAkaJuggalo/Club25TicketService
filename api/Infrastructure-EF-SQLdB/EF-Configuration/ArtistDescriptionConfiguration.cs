using Club25_Domain.Agregates.BandAgregate.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration;

public sealed class ArtistDescriptionConfiguration : IEntityTypeConfiguration<ArtistDescription>
{
	public void Configure(EntityTypeBuilder<ArtistDescription> builder)
	{
		builder.HasNoKey()
		       .ToTable("ArtistDescription");

		builder.HasOne(d => d.IdArtistNavigation).WithMany()
		       .HasForeignKey(d => d.IdArtist)
		       .OnDelete(DeleteBehavior.ClientSetNull)
		       .HasConstraintName("FK_ArtistDescription_Artist");

		builder.HasOne(d => d.IdLanguageNavigation).WithMany()
		       .HasForeignKey(d => d.IdLanguage)
		       .OnDelete(DeleteBehavior.ClientSetNull)
		       .HasConstraintName("FK_ArtistDescription_Language");

		builder.Property(e => e.Description).HasColumnName("description");
		builder.Property(e => e.IdArtist).HasColumnName("idArtist");
		builder.Property(e => e.IdLanguage).HasColumnName("idLanguage");
	}
}