using Club25_Domain.Common.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration.Club25Context.Common;

public sealed class PersonConfiguration : IEntityTypeConfiguration<Person>
{
	public void Configure(EntityTypeBuilder<Person> builder)
	{
		var columnOrder = 0;
		builder.UseTpcMappingStrategy();

		builder.Property(e => e.Id)
		       .ValueGeneratedNever()
		       .HasColumnName(nameof(Person.Id).ToLower())
		       .HasColumnOrder(columnOrder++);

		builder.Property(x => x.Name)
		       .IsRequired()
		       .HasColumnOrder(columnOrder++)
		       .HasColumnName(nameof(Person.Name).ToLower())
		       .HasMaxLength(64);

		builder.Property(x => x.Surname)
		       .IsRequired()
		       .HasColumnOrder(columnOrder)
		       .HasColumnName(nameof(Person.Surname).ToLower())
		       .HasMaxLength(64);
	}
}