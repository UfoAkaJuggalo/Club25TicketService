using Club25_Domain.Agregates.EventAgregate.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration;

public sealed class CultureConfiguration : IEntityTypeConfiguration<Culture>
{
	public void Configure(EntityTypeBuilder<Culture> builder)
	{
		builder.ToTable("Culture");

		builder.HasOne(d => d.IdCurrencyNavigation).WithMany(p => p.Cultures)
		       .HasForeignKey(d => d.IdCurrency)
		       .OnDelete(DeleteBehavior.ClientSetNull)
		       .HasConstraintName("FK_Culture_Currency");

		builder.HasOne(d => d.IdLanguageNavigation).WithMany(p => p.Cultures)
		       .HasForeignKey(d => d.IdLanguage)
		       .OnDelete(DeleteBehavior.ClientSetNull)
		       .HasConstraintName("FK_Culture_Language");

		builder.Property(e => e.Id)
		       .ValueGeneratedNever()
		       .HasColumnName("id");

		builder.Property(e => e.IdCurrency).HasColumnName("idCurrency");
		builder.Property(e => e.IdLanguage).HasColumnName("idLanguage");
		builder.Property(e => e.Name)
		       .HasMaxLength(25)
		       .HasColumnName("name");
		builder.Property(e => e.ShortName)
		       .HasMaxLength(25)
		       .HasColumnName("shortName");
	}
}