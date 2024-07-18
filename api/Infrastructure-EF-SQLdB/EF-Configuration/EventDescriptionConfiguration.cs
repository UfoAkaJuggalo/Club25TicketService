using Club25_Domain.Agregates.EventAgregate.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration;

public sealed class EventDescriptionConfiguration : IEntityTypeConfiguration<EventDescription>
{
	public void Configure(EntityTypeBuilder<EventDescription> builder)
	{
		builder.HasNoKey()
		       .ToTable("EventDescription");

		builder.HasOne(d => d.IdEventNavigation).WithMany()
		       .HasForeignKey(d => d.IdEvent)
		       .OnDelete(DeleteBehavior.ClientSetNull)
		       .HasConstraintName("FK_EventDescription_Event");

		builder.HasOne(d => d.IdLanguageNavigation).WithMany()
		       .HasForeignKey(d => d.IdLanguage)
		       .OnDelete(DeleteBehavior.ClientSetNull)
		       .HasConstraintName("FK_EventDescription_Language");

		builder.Property(e => e.Description).HasColumnName("description");
		builder.Property(e => e.IdEvent).HasColumnName("idEvent");
		builder.Property(e => e.IdLanguage).HasColumnName("idLanguage");
	}
}