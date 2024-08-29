using Club25_Domain.Aggregates.SponsorAggregate.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration;

public sealed class MainSponsorConfiguration : IEntityTypeConfiguration<MainSponsor>
{
	public void Configure(EntityTypeBuilder<MainSponsor> builder)
	{
		builder.HasNoKey()
		       .ToTable("MainSponsor");

		builder.HasOne(d => d.IdPriceNavigation).WithMany()
		       .HasForeignKey(d => d.IdPrice)
		       .HasConstraintName("FK_MainSponsor_Price");

		builder.HasOne(d => d.IdSponsorNavigation).WithMany()
		       .HasForeignKey(d => d.IdSponsor)
		       .OnDelete(DeleteBehavior.ClientSetNull)
		       .HasConstraintName("FK_MainSponsor_Sponsor");

		builder.Property(e => e.DateEnd).HasColumnName("dateEnd");
		builder.Property(e => e.DateStart).HasColumnName("dateStart");
		builder.Property(e => e.Description)
		       .HasMaxLength(250)
		       .HasColumnName("description");
		builder.Property(e => e.IdPrice).HasColumnName("idPrice");
		builder.Property(e => e.IdSponsor).HasColumnName("idSponsor");
	}
}