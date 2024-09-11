using Club25_Domain.Aggregates.TicketPoolAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration;

public sealed class TicketPoolConfiguration : IEntityTypeConfiguration<TicketPool>
{
	public void Configure(EntityTypeBuilder<TicketPool> builder)
	{
		builder.ToTable("TicketPool");

		builder.HasOne(d => d.IdTicketMediaNavigation).WithMany(p => p.TicketPools)
		       .HasForeignKey(d => d.IdTicketMedia)
		       .OnDelete(DeleteBehavior.ClientSetNull)
		       .HasConstraintName("FK_TicketPool_TicketMediaType");

		builder.HasOne(d => d.IdTicketTypeNavigation).WithMany(p => p.TicketPools)
		       .HasForeignKey(d => d.IdTicketType)
		       .OnDelete(DeleteBehavior.ClientSetNull)
		       .HasConstraintName("FK_TicketPool_TicketType");

		builder.HasOne(d => d.IdVendorNavigation).WithMany(p => p.TicketPools)
		       .HasForeignKey(d => d.IdVendor)
		       .OnDelete(DeleteBehavior.ClientSetNull)
		       .HasConstraintName("FK_TicketPool_Vendor");

		builder.Property(e => e.Id)
		       .ValueGeneratedNever()
		       .HasColumnName("id");
		builder.Property(e => e.Amount).HasColumnName("amount");
		builder.Property(e => e.DateEnd).HasColumnName("dateEnd");
		builder.Property(e => e.DateStart).HasColumnName("dateStart");
		builder.Property(e => e.IdPrice).HasColumnName("idPrice");
		builder.Property(e => e.IdTicketMedia).HasColumnName("idTicketMedia");
		builder.Property(e => e.IdTicketType).HasColumnName("idTicketType");
		builder.Property(e => e.IdVendor).HasColumnName("idVendor");
		builder.Property(e => e.Profit)
		       .HasColumnType("decimal(18, 0)")
		       .HasColumnName("profit");
	}
}