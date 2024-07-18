namespace Club25_Domain.Agregates.AgencyAgregate.ValueObjects;

public sealed class ContactVO
{
	public required string Email { get; set; }
	public string? Phone { get; set; }
	public string? Country { get; set; }
	public string? City { get; set; }
	public string? Address { get; set; }
}