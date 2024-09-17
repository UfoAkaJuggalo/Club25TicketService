using Club25_Domain.Aggregates.ClientAggregate.Entities;
using Club25_Domain.Common.Entities;

namespace Club25_Domain.Aggregates.ClientAggregate;

public sealed class Client : UserAccount
{
	public string? Phone { get; init; }

	public DateOnly BirthDate { get; set; }

	//public ClientConfigVO ClientConfig { get; set; } = new();
	public ICollection<int> FavouriteVenuesIds { get; set; } = new List<int>();
	public ICollection<int> FavouriteEventsIds { get; set; } = new List<int>();
	public ICollection<int> FavouriteBandssIds { get; set; } = new List<int>();
	public ICollection<Purchase> Purchases { get; set; } = new List<Purchase>();
}