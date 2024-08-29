using Club25_Domain.Aggregates.TicketPoolAggregate.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration;

public sealed class VendorConfiguration : IEntityTypeConfiguration<Vendor>
{
	public void Configure(EntityTypeBuilder<Vendor> builder)
	{
		builder.ToTable("Vendor");

		builder.Property(e => e.Id)
		       .ValueGeneratedNever()
		       .HasColumnName("id");
		builder.Property(e => e.Adres)
		       .HasMaxLength(50)
		       .HasColumnName("adres");
		builder.Property(e => e.AverageProfit)
		       .HasColumnType("decimal(18, 0)")
		       .HasColumnName("averageProfit");
		builder.Property(e => e.City)
		       .HasMaxLength(50)
		       .HasColumnName("city");
		builder.Property(e => e.Email)
		       .HasMaxLength(25)
		       .HasColumnName("email");
		builder.Property(e => e.Hash)
		       .HasMaxLength(25)
		       .HasColumnName("hash");
		builder.Property(e => e.Name)
		       .HasMaxLength(50)
		       .HasColumnName("name");
		builder.Property(e => e.Phone)
		       .HasMaxLength(25)
		       .HasColumnName("phone");
		builder.Property(e => e.Www)
		       .HasMaxLength(25)
		       .HasColumnName("www");
	}
}