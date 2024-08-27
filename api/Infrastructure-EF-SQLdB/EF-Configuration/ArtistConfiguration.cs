using Club25_Domain.Agregates.AgencyAgregate.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration;

public sealed class ArtistConfiguration : IEntityTypeConfiguration<Artist>
{
	public void Configure(EntityTypeBuilder<Artist> builder)
	{
		var columnOrder = 0;

		builder.ToTable(nameof(Artist));

		builder.HasMany(m => m.ArtistDescriptions)
		       .WithOne(o => o.Artist)
		       .HasForeignKey(k => k.ArtistId)
		       .OnDelete(DeleteBehavior.ClientSetNull);

		builder.HasMany(m => m.Links)
		       .WithOne();

		builder.HasMany(m => m.Tags)
		       .WithMany(m => m.Artists);

		builder.Property(e => e.Id)
		       .ValueGeneratedNever()
		       .HasColumnName(nameof(Artist.Id).ToLower())
		       .HasColumnOrder(columnOrder++);
		builder.Property(e => e.Name)
		       .HasMaxLength(64)
		       .HasColumnName(nameof(Artist.Name).ToLower())
		       .HasColumnOrder(columnOrder++);
		builder.Property(e => e.Surname)
		       .HasMaxLength(64)
		       .HasColumnName(nameof(Artist.Surname).ToLower())
		       .HasColumnOrder(columnOrder++);
		builder.Property(e => e.StageName)
		       .HasMaxLength(64)
		       .HasColumnName(nameof(Artist.StageName).ToLower())
		       .HasColumnOrder(columnOrder++);
	}
}