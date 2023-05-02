namespace Inventory_M.Models.users_management;

public class user
{
    public Guid UserId { get; set; }
    public string Email { get; set; }
    public string PassWord { get; set; }
    public bool KeepLoggedIn { get; set; }

    public ICollection<role> roles { get; set; }

}
