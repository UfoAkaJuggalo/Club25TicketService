using Club25_Domain.Agregates.ClientAgregate.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration;

public sealed class PersonConfiguration : IEntityTypeConfiguration<Person>
{
	public void Configure(EntityTypeBuilder<Person> builder)
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