using Club25_Domain.Aggregates.UserAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure_EF_SQLdB.EF_Configuration.Club25UsersContext;

public sealed class UserConfiguration : IEntityTypeConfiguration<User>
{
	public void Configure(EntityTypeBuilder<User> builder)
	{
		builder.ToTable(nameof(User));

		builder.HasMany(m => m.UserGroups)
		       .WithMany(m => m.Users);

		builder.HasMany(m => m.Permissions)
		       .WithMany();

		//builder.ComplexProperty(p => p.UserConfig);
	}
}