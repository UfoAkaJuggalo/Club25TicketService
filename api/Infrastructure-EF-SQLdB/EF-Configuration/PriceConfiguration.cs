using Club25_Domain.Aggregates.EventAggregate.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration;

public sealed class PriceConfiguration : IEntityTypeConfiguration<Price>
{
	public void Configure(EntityTypeBuilder<Price> builder)
	{
		builder.ToTable("Price");

		builder.HasOne(d => d.IdCurrencyNavigation).WithMany(p => p.Prices)
		       .HasForeignKey(d => d.IdCurrency)
		       .OnDelete(DeleteBehavior.ClientSetNull)
		       .HasConstraintName("FK_Price_Currency");

		builder.Property(e => e.Id)
		       .ValueGeneratedNever()
		       .HasColumnName("id");
		builder.Property(e => e.Amount).HasColumnName("amount");
		builder.Property(e => e.IdCurrency).HasColumnName("idCurrency");
	}
}