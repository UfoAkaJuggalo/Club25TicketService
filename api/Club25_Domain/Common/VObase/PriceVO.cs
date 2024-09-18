using System.Globalization;
using Club25_Domain.Enum;

namespace Club25_Domain.Common.VObase;

public abstract record PriceVO
{
	public decimal Price { get; set; }
	public Currency Currency { get; set; }

	public string GetPrice() => $"{Price.ToString(CultureInfo.CurrentCulture)} {Currency.ToString().ToUpper()}";
}