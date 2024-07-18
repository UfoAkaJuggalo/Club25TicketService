using Club25_Domain.Agregates.ClientAgregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration;

public sealed class ClientConfiguration : IEntityTypeConfiguration<Client>
{
	public void Configure(EntityTypeBuilder<Client> builder)
	{
		builder.ToTable("Client");

		builder.Property(e => e.Id)
		       .ValueGeneratedNever()
		       .HasColumnName("id");
		builder.Property(e => e.IdPerson).HasColumnName("id_person");
		builder.Property(e => e.Phone)
		       .HasMaxLength(15)
		       .HasColumnName("phone");

		builder.HasOne(d => d.IdPersonNavigation).WithMany(p => p.Clients)
		       .HasForeignKey(d => d.IdPerson)
		       .OnDelete(DeleteBehavior.ClientSetNull)
		       .HasConstraintName("FK_Client_Person");
	}
}