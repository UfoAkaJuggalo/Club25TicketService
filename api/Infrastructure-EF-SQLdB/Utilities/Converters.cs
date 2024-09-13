using Club25_Domain.Aggregates.TicketPoolAggregate.Enums;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure_EF_SQLdB.Utilities;

public static class Converters
{
	public static ValueConverter<ICollection<TicketMediaType>, string> TicketMediaTypeConverter { get; } =
		new(
			v => string.Join(',', v),
			v => ConvertStringDataToTicketMediaTypeList(v));

	private static ICollection<TicketMediaType> ConvertStringDataToTicketMediaTypeList(string data)
	{
		var result = new List<TicketMediaType>();
		var stringList = data.Split(',', StringSplitOptions.RemoveEmptyEntries).ToList();
		stringList.ForEach(x =>
		{
			if (Enum.TryParse(x, out TicketMediaType mediaType))
				result.Add(mediaType);
		});

		return result;
	}
}