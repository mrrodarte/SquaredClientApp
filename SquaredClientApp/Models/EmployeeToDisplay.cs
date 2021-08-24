using System;
using System.Collections.Generic;
using System.Text;

namespace SquaredClientApp.Models
{
    /// <summary>
    /// We will use this class to display employee managers to combo box
    /// not all fields from entity needs to display.  Easier to manage this way.
    /// </summary>
    public class EmployeeToDisplay
    {
        public int Id { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string RoleDescription { get; set; }

        public bool IsManagerRole { get; set; }
    }
}
