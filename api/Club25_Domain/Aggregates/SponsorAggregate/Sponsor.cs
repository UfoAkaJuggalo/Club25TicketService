namespace Club25_Domain.Aggregates.SponsorAggregate;

public class Sponsor
{
	public int Id { get; set; }

	public string Name { get; set; } = null!;

	public string? Www { get; set; }

	public string? Phone { get; set; }

	public string? Email { get; set; }

	public string? Details { get; set; }

	public byte[] Logo { get; set; } = null!;

	public byte[] LogoBlack { get; set; } = null!;
}