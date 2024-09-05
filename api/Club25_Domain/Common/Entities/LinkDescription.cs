namespace Club25_Domain.Common.Entities;

public sealed class LinkDescription : Description
{
	public Link Link { get; init; }
	public int LinkId { get; init; }
}