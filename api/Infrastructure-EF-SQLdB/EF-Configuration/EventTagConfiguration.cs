using Club25_Domain.Agregates.EventAgregate.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration;

public sealed class EventTagConfiguration : IEntityTypeConfiguration<EventTag>
{
	public void Configure(EntityTypeBuilder<EventTag> builder)
	{
		builder.HasNoKey()
		       .ToTable("EventTag");

		builder.HasOne(d => d.IdEventNavigation).WithMany()
		       .HasForeignKey(d => d.IdEvent)
		       .OnDelete(DeleteBehavior.ClientSetNull)
		       .HasConstraintName("FK_EventTag_Event");

		builder.HasOne(d => d.IdTagNavigation).WithMany()
		       .HasForeignKey(d => d.IdTag)
		       .OnDelete(DeleteBehavior.ClientSetNull)
		       .HasConstraintName("FK_EventTag_Tag");

		builder.Property(e => e.IdEvent).HasColumnName("idEvent");
		builder.Property(e => e.IdTag).HasColumnName("idTag");
	}
}