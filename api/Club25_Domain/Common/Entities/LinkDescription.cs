namespace Club25_Domain.Common.Entities;

public sealed record LinkDescription : Description
{
	public Link Link { get; init; }
	public int LinkId { get; init; }
}