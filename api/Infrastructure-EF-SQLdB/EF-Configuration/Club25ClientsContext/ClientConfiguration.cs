using Club25_Domain.Aggregates.ClientAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration.Club25ClientsContext;

public sealed class ClientConfiguration : IEntityTypeConfiguration<Client>
{
	public void Configure(EntityTypeBuilder<Client> builder)
	{
		builder.ToTable(nameof(Client));

		builder.HasMany(m => m.Purchases)
		       .WithOne(m => m.Client)
		       .HasForeignKey(f => f.ClientId);

		var columnOrder = 0;

		builder.Property(p => p.Phone)
		       .HasColumnName(nameof(Client.Phone).ToLower())
		       .HasColumnOrder(columnOrder++)
		       .HasMaxLength(16);

		builder.Property(p => p.BirthDate)
		       .HasColumnName(nameof(Client.BirthDate).ToLower())
		       .HasColumnOrder(columnOrder++)
		       .HasConversion<DateOnly>();

		//builder.ComplexProperty(c => c.ClientConfig);

		builder.PrimitiveCollection(p => p.FavouriteVenuesIds)
		       .HasColumnName(nameof(Client.FavouriteVenuesIds).ToLower())
		       .HasColumnOrder(columnOrder++);

		builder.PrimitiveCollection(p => p.FavouriteEventsIds)
		       .HasColumnName(nameof(Client.FavouriteEventsIds).ToLower())
		       .HasColumnOrder(columnOrder++);
		;

		builder.PrimitiveCollection(p => p.FavouriteBandssIds)
		       .HasColumnName(nameof(Client.FavouriteBandssIds).ToLower())
		       .HasColumnOrder(columnOrder);
	}
}