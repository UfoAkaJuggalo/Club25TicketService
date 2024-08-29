using Club25_Domain.Aggregates.TicketPoolAggregate.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration;

public sealed class TicketConfiguration : IEntityTypeConfiguration<Ticket>
{
	public void Configure(EntityTypeBuilder<Ticket> builder)
	{
		builder.ToTable("Ticket");

		builder.HasOne(d => d.IdClientNavigation).WithMany(p => p.Tickets)
		       .HasForeignKey(d => d.IdClient)
		       .OnDelete(DeleteBehavior.ClientSetNull)
		       .HasConstraintName("FK_Ticket_Client");

		builder.HasOne(d => d.IdTicketPoolNavigation).WithMany(p => p.Tickets)
		       .HasForeignKey(d => d.IdTicketPool)
		       .OnDelete(DeleteBehavior.ClientSetNull)
		       .HasConstraintName("FK_Ticket_TicketPool");

		builder.Property(e => e.Id)
		       .ValueGeneratedNever()
		       .HasColumnName("id");
		builder.Property(e => e.Hash)
		       .HasMaxLength(20)
		       .HasColumnName("hash");
		builder.Property(e => e.IdClient).HasColumnName("idClient");
		builder.Property(e => e.IdTicketPool).HasColumnName("idTicketPool");
		builder.Property(e => e.SeatNumber).HasColumnName("seatNumber");
		builder.Property(e => e.SoldDate).HasColumnName("soldDate");
	}
}