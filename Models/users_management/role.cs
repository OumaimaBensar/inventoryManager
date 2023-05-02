namespace Inventory_M.Models.users_management;

public class role
{
    public Guid roleid { get; set; }
    public string rolename { get; set; }
    public ICollection<user> users { get; set; }

    
}
