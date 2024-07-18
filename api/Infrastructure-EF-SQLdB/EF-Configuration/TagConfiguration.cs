using Club25_Domain.Agregates.TagAgregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration;

public sealed class TagConfiguration : IEntityTypeConfiguration<Tag>
{
	public void Configure(EntityTypeBuilder<Tag> builder)
	{
		builder.ToTable("Tag");

		builder.Property(e => e.Id)
		       .ValueGeneratedNever()
		       .HasColumnName("id");
		builder.Property(e => e.Name)
		       .HasMaxLength(20)
		       .HasColumnName("name");
	}
}