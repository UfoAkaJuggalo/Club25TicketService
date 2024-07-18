using Club25_Domain.Agregates.UserAgregate;

namespace Club25_Domain.Agregates.ClientAgregate.Entities;

public partial class Person
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Surname { get; set; } = null!;

    public string Email { get; set; } = null!;

    public virtual ICollection<Client> Clients { get; set; } = new List<Client>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
