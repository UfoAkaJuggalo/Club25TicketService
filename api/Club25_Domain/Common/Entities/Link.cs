using Club25_Domain.Enum;

namespace Club25_Domain.Common.Entities;

public sealed record Link
{
	public int Id { get; set; }
	public required Uri Url { get; set; }
	public string? Name { get; set; }
	public ICollection<LinkDescription> LinkDescriptions { get; set; } = new List<LinkDescription>();
	public LinkType LinkType { get; set; } = LinkType.www;
}