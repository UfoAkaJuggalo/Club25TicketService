namespace Club25_Domain.Aggregates.SponsorAggregate;

public class Sponsor
{
	public int Id { get; init; }

	public string Name { get; init; } = null!;

	public string? Www { get; init; }

	public string? Phone { get; init; }

	public string? Email { get; init; }

	public string? Details { get; init; }

	public byte[] Logo { get; init; } = null!;

	public byte[] LogoBlack { get; init; } = null!;
}