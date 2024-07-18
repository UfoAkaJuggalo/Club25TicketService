using Club25_Domain.Agregates.EventAgregate.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration;

public sealed class LineupConfiguration : IEntityTypeConfiguration<Lineup>
{
	public void Configure(EntityTypeBuilder<Lineup> builder)
	{
		builder.HasNoKey()
		       .ToTable("Lineup");

		builder.HasOne(d => d.IdArtistNavigation).WithMany()
		       .HasForeignKey(d => d.IdArtist)
		       .HasConstraintName("FK_Lineup_Artist");

		builder.HasOne(d => d.IdEventNavigation).WithMany()
		       .HasForeignKey(d => d.IdEvent)
		       .OnDelete(DeleteBehavior.ClientSetNull)
		       .HasConstraintName("FK_Lineup_Event");

		builder.HasOne(d => d.IdStageNavigation).WithMany()
		       .HasForeignKey(d => d.IdStage)
		       .HasConstraintName("FK_Lineup_Stage");

		builder.Property(e => e.Description)
		       .HasMaxLength(50)
		       .HasColumnName("description");

		builder.Property(e => e.IdArtist).HasColumnName("idArtist");
		builder.Property(e => e.IdEvent).HasColumnName("idEvent");
		builder.Property(e => e.IdStage).HasColumnName("idStage");
		builder.Property(e => e.StartTime).HasColumnName("startTime");
		builder.Property(e => e.StopTime).HasColumnName("stopTime");
	}
}