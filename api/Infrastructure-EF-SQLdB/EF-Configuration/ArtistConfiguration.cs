using Club25_Domain.Aggregates.PromoterAgencyAggregate.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration;

public sealed class ArtistConfiguration : IEntityTypeConfiguration<Artist>
{
	public void Configure(EntityTypeBuilder<Artist> builder)
	{
		builder.ToTable(nameof(Artist))
		       .HasKey(k => k.Id);

		builder.HasMany(m => m.ArtistDescriptions)
		       .WithOne(o => o.Artist)
		       .HasForeignKey(k => k.ArtistId)
		       .OnDelete(DeleteBehavior.ClientSetNull);

		builder.HasMany(m => m.Links)
		       .WithOne();

		builder.HasMany(m => m.Tags)
		       .WithMany(m => m.Artists);

		builder.Property(e => e.StageName)
		       .HasMaxLength(64)
		       .HasColumnName(nameof(Artist.StageName).ToLower());
	}
}