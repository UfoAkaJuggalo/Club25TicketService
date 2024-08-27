using Club25_Domain.Agregates.AgencyAgregate.Entities;
using Club25_Domain.Agregates.AgencyAgregate.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration;

public sealed class AgentConfiguration : IEntityTypeConfiguration<Agent>
{
	public void Configure(EntityTypeBuilder<Agent> builder)
	{
		builder.ToTable(nameof(Agent))
		       .HasKey(x => x.Id);

		var columnOrder = 0;

		builder.Property(x => x.Name)
		       .IsRequired()
		       .HasColumnOrder(columnOrder++)
		       .HasColumnName(nameof(Agent.Name).ToLower())
		       .HasMaxLength(64);

		builder.Property(x => x.Surname)
		       .IsRequired()
		       .HasColumnOrder(columnOrder++)
		       .HasColumnName(nameof(Agent.Surname).ToLower())
		       .HasMaxLength(64);

		builder.OwnsOne(o => o.Contact, navigationBuilder =>
		{
			navigationBuilder.Property(p => p.Email)
			                 .IsRequired()
			                 .HasColumnName(nameof(ContactVO.Email).ToLower())
			                 .HasColumnOrder(columnOrder++)
			                 .HasMaxLength(32);
			navigationBuilder.Property(p => p.Phone)
			                 .HasColumnName(nameof(ContactVO.Phone).ToLower())
			                 .HasColumnOrder(columnOrder++)
			                 .HasMaxLength(16);
			navigationBuilder.Property(p => p.Country)
			                 .HasColumnName(nameof(ContactVO.Country).ToLower())
			                 .HasColumnOrder(columnOrder++)
			                 .HasMaxLength(64);
			navigationBuilder.Property(p => p.City)
			                 .HasColumnName(nameof(ContactVO.City).ToLower())
			                 .HasColumnOrder(columnOrder++)
			                 .HasMaxLength(64);
			navigationBuilder.Property(p => p.Address)
			                 .HasColumnName(nameof(ContactVO.Address).ToLower())
			                 .HasColumnOrder(columnOrder++)
			                 .HasMaxLength(100);
		});
	}
}