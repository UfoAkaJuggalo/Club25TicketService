using Club25_Domain.Enum;

namespace Club25_Domain.Common.Entities;

public abstract class Description
{
	public int Id { get; set; }
	public CountryCode LanguageCode { get; set; } = CountryCode.en;
	public string? DescriptionText { get; set; }
}