using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace SquaredClientApp.Entities
{
    public class Employee 
    {
        //A Guid indentity type could be used, but to keep this simple lets choose int
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; } 

        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        public int? ReportsTo { get; set; }

        public ICollection<EmployeeRole> EmployeeRoles { get; set; }
    }
}
