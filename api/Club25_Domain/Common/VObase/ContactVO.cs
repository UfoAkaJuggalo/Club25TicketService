namespace Club25_Domain.Common.VObase;

public abstract record ContactVO
{
	public required string Email { get; set; }
	public string? Phone { get; set; }
	public string? Country { get; set; }
	public string? City { get; set; }
	public string? Address { get; set; }
}