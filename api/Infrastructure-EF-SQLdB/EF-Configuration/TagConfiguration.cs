using Club25_Domain.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration;

public sealed class TagConfiguration : IEntityTypeConfiguration<Tag>
{
	public void Configure(EntityTypeBuilder<Tag> builder)
	{
		builder.ToTable(nameof(Tag));

		builder.Property(e => e.Id)
		       .ValueGeneratedNever()
		       .HasColumnName(nameof(Tag.Id).ToLower());
		builder.Property(e => e.Name)
		       .HasMaxLength(20)
		       .HasColumnName(nameof(Tag.Name).ToLower());
	}
}