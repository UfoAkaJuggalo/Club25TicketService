namespace Club25_Domain.Common.Entities;

public sealed class LinkDescription : Description
{
	public Link Link { get; set; }
	public int LinkId { get; set; }
}