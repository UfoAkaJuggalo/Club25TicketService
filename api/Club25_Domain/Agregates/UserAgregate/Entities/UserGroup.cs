namespace Club25_Domain.Agregates.UserAgregate.Entities;

public partial class UserGroup
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
