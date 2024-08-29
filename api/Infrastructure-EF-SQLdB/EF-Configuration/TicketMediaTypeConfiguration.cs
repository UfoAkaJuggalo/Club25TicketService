using Club25_Domain.Aggregates.TicketPoolAggregate.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration;

public sealed class TicketMediaTypeConfiguration : IEntityTypeConfiguration<TicketMediaType>
{
	public void Configure(EntityTypeBuilder<TicketMediaType> builder)
	{
		builder.ToTable("TicketMediaType");

		builder.Property(e => e.Id)
		       .ValueGeneratedNever()
		       .HasColumnName("id");
		builder.Property(e => e.Name)
		       .HasMaxLength(25)
		       .HasColumnName("name");
	}
}