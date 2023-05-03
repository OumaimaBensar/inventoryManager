using System.Collections.Generic;
using Inventory_M.Models.users_management;

namespace Inventory_M.Models.ViewModels
{
    public class EmployeeViewModel
    {
        public List<user> Users { get; set; }
        public List<role> URoles { get; set; }
    }
}
