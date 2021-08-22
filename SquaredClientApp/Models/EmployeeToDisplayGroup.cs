using System;
using System.Collections.Generic;
using System.Text;

namespace SquaredClientApp.Models
{
    /// <summary>
    /// We will use this class to display distinct employees and flatten the roles
    /// not all fields from entity needs to display.  Easier to manage this way.
    /// </summary>
    public class EmployeeToDisplayGroup
    {
        public int Id { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string RoleDescription { get; set; }

    }
}
