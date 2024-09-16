using Club25_Domain.Aggregates.TicketPoolAggregate.Entities;
using Club25_Domain.Aggregates.TicketPoolAggregate.Enums;
using Club25_Domain.Common.VObase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure_EF_SQLdB.EF_Configuration.Club25Context.TicketPoolAggregate;

public sealed class TicketConfiguration : IEntityTypeConfiguration<Ticket>
{
	public void Configure(EntityTypeBuilder<Ticket> builder)
	{
		builder.ToTable(nameof(Ticket))
		       .HasKey(k => k.Id);

		builder.HasMany(m => m.Discounts)
		       .WithMany(m => m.Tickets);

		var columnOrder = 0;

		// builder.HasOne(d => d.IdClientNavigation).WithMany(p => p.Tickets)
		//        .HasForeignKey(d => d.IdClient)
		//        .OnDelete(DeleteBehavior.ClientSetNull)
		//        .HasConstraintName("FK_Ticket_Client");


		builder.Property(e => e.Id)
		       .HasColumnName(nameof(Ticket.Id).ToLower())
		       .HasColumnOrder(columnOrder++)
		       .ValueGeneratedOnAdd()
		       .HasConversion<Guid>();
		builder.Property(p => p.SoldDate)
		       .HasColumnName(nameof(Ticket.SoldDate).ToLower())
		       .HasColumnOrder(columnOrder++)
		       .HasConversion(new DateTimeToStringConverter());
		builder.Property(p => p.SeatNumber)
		       .HasColumnName(nameof(Ticket.SeatNumber).ToLower())
		       .HasColumnOrder(columnOrder++);
		builder.Property(p => p.TicketStatus)
		       .HasColumnName(nameof(TicketStatus).ToLower())
		       .HasColumnOrder(columnOrder++)
		       .HasConversion(new EnumToStringConverter<TicketStatus>());
		builder.Property(p => p.MediaType)
		       .HasColumnName(nameof(Ticket.MediaType).ToLower())
		       .HasColumnOrder(columnOrder)
		       .HasConversion(new EnumToStringConverter<TicketMediaType>());

		builder.OwnsOne(o => o.TicketPrice, navigationBuilder =>
		{
			navigationBuilder.Property(p => p.Price)
			                 .HasColumnName(nameof(PriceVO.Price).ToLower())
			                 .HasPrecision(10, 2);
			navigationBuilder.Property(p => p.Currency)
			                 .HasColumnName(nameof(PriceVO.Currency).ToLower())
			                 .HasConversion<string>();
		});
	}
}