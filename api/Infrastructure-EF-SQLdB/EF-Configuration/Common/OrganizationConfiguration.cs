using Club25_Domain.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration.Common;

public sealed class OrganizationConfiguration : IEntityTypeConfiguration<Organization>
{
	public void Configure(EntityTypeBuilder<Organization> builder)
	{
		var columnOrder = 0;
		builder.UseTpcMappingStrategy();

		builder.Property(e => e.Id)
		       .ValueGeneratedNever()
		       .HasColumnName(nameof(Organization.Id).ToLower())
		       .HasColumnOrder(columnOrder++);

		builder.Property(x => x.Name)
		       .IsRequired()
		       .HasColumnOrder(columnOrder++)
		       .HasColumnName(nameof(Organization.Name).ToLower())
		       .HasMaxLength(100);
	}
}