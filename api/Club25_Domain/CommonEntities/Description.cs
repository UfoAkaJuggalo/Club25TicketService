using Club25_Domain.Enum;

namespace Club25_Domain.CommonEntities;

public abstract class Description
{
	public int Id { get; set; }
	public CountryCode LanguageCode { get; set; } = CountryCode.en;
	public string? DescriptionText { get; set; }
}