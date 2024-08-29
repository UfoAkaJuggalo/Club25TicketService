using Club25_Domain.Agregates.ClientAgregate.Entities;
using Club25_Domain.Agregates.PromoterAgencyAgregate;
using Club25_Domain.Agregates.UserAgregate.Entities;
using Club25_Domain.CommonEntities;

namespace Club25_Domain.Agregates.UserAgregate;

public class User : Person
{
	public int Id { get; set; }

	public int IdPerson { get; set; }

	public int IdGroup { get; set; }

	public string Password { get; set; } = null!;

	public virtual UserGroup IdGroupNavigation { get; set; } = null!;

	public virtual PersonObsolete IdPersonNavigation { get; set; } = null!;
	public ICollection<PromoterAgency> PromoterAgencies { get; set; } = new List<PromoterAgency>();
}