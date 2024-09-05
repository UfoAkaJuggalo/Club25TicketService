using Club25_Domain.Enum;

namespace Club25_Domain.Common.Entities;

public abstract class Description
{
	public int Id { get; init; }
	public CountryCode LanguageCode { get; init; } = CountryCode.en;
	public string? DescriptionText { get; init; }
}