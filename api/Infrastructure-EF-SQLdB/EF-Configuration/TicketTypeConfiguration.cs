using Club25_Domain.Agregates.TicketPoolAgregate.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration;

public sealed class TicketTypeConfiguration : IEntityTypeConfiguration<TicketType>
{
	public void Configure(EntityTypeBuilder<TicketType> builder)
	{
		builder.ToTable("TicketType");

		builder.Property(e => e.Id)
		       .ValueGeneratedNever()
		       .HasColumnName("id");
		builder.Property(e => e.Name)
		       .HasMaxLength(20)
		       .HasColumnName("name");
	}
}