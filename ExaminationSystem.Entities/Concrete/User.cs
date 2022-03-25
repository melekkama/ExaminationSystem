#nullable disable
namespace ExaminationSystem.Entities.Concrete;

public class User:EntityBase
{
    public string Email { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Passowrd { get; set; }

    public Guid RoleId { get; set; }
    public Role Role { get; set; }
}
