using Club25_Domain.Agregates.ClientAgregate.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration;

public sealed class PersonObsoleteConfiguration : IEntityTypeConfiguration<PersonObsolete>
{
	public void Configure(EntityTypeBuilder<PersonObsolete> builder)
	{
		builder.ToTable("Person");

		builder.Property(e => e.Id)
		       .ValueGeneratedNever()
		       .HasColumnName("id");
		builder.Property(e => e.Email)
		       .HasMaxLength(50)
		       .HasColumnName("email");
		builder.Property(e => e.Name)
		       .HasMaxLength(20)
		       .HasColumnName("name");
		builder.Property(e => e.Surname)
		       .HasMaxLength(50)
		       .HasColumnName("surname");
	}
}