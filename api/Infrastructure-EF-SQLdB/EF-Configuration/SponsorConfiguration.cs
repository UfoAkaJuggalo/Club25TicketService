using Club25_Domain.Aggregates.SponsorAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration;

public sealed class SponsorConfiguration : IEntityTypeConfiguration<Sponsor>
{
	public void Configure(EntityTypeBuilder<Sponsor> builder)
	{
		builder.ToTable("Sponsor");

		builder.Property(e => e.Id)
		       .ValueGeneratedNever()
		       .HasColumnName("id");
		builder.Property(e => e.Details)
		       .HasMaxLength(255)
		       .HasColumnName("details");
		builder.Property(e => e.Email)
		       .HasMaxLength(20)
		       .HasColumnName("email");
		builder.Property(e => e.Logo).HasColumnName("logo");
		builder.Property(e => e.LogoBlack).HasColumnName("logoBlack");
		builder.Property(e => e.Name)
		       .HasMaxLength(25)
		       .HasColumnName("name");
		builder.Property(e => e.Phone)
		       .HasMaxLength(15)
		       .HasColumnName("phone");
		builder.Property(e => e.Www)
		       .HasMaxLength(20)
		       .HasColumnName("www");
	}
}