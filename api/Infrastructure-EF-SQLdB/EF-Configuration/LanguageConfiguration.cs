using Club25_Domain.Agregates.EventAgregate.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration;

public sealed class LanguageConfiguration : IEntityTypeConfiguration<Language>
{
	public void Configure(EntityTypeBuilder<Language> builder)
	{
		builder.ToTable("Language");

		builder.Property(e => e.Id)
		       .ValueGeneratedNever()
		       .HasColumnName("id");
		builder.Property(e => e.Name)
		       .HasMaxLength(15)
		       .HasColumnName("name");
		builder.Property(e => e.ShortName)
		       .HasMaxLength(4)
		       .HasColumnName("shortName");
	}
}