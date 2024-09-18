using Club25_Domain.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration.Club25Context;

public sealed class TagConfiguration : IEntityTypeConfiguration<Tag>
{
	public void Configure(EntityTypeBuilder<Tag> builder)
	{
		builder.ToTable(nameof(Tag))
		       .HasKey(k => k.Id);

		var columnOrder = 0;

		builder.Property(e => e.Id)
		       .UseIdentityColumn()
		       .HasColumnOrder(columnOrder++)
		       .HasColumnName(nameof(Tag.Id).ToLower());
		builder.Property(e => e.Name)
		       .HasMaxLength(20)
		       .HasColumnOrder(columnOrder)
		       .HasColumnName(nameof(Tag.Name).ToLower());
	}
}