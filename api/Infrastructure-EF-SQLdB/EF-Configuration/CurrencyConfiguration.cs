using Club25_Domain.Agregates.EventAgregate.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration;

public sealed class CurrencyConfiguration : IEntityTypeConfiguration<Currency>
{
	public void Configure(EntityTypeBuilder<Currency> builder)
	{
		builder.ToTable("Currency");

		builder.Property(e => e.Id)
		       .ValueGeneratedNever()
		       .HasColumnName("id");
		builder.Property(e => e.Name)
		       .HasMaxLength(10)
		       .HasColumnName("name");
		builder.Property(e => e.Shortname)
		       .HasMaxLength(5)
		       .HasColumnName("shortname");
	}
}