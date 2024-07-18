using Club25_Domain.Agregates.ClientAgregate.Entities;
using Club25_Domain.Agregates.UserAgregate.Entities;

namespace Club25_Domain.Agregates.UserAgregate;

public partial class User
{
    public int Id { get; set; }

    public int IdPerson { get; set; }

    public int IdGroup { get; set; }

    public string Password { get; set; } = null!;

    public virtual UserGroup IdGroupNavigation { get; set; } = null!;

    public virtual Person IdPersonNavigation { get; set; } = null!;
}
