using FuelStation.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.Blazor.Shared
{
    } public class UserToAuthViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }

    public class UserAuthenticatedViewModel
    {
        public string? Username { get; set; }
        public EmployeeTypeEnum? EmployeeType { get; set; }
}
