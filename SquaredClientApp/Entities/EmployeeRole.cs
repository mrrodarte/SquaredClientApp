using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace TylerTechClientApp.Entities
{
    public class EmployeeRole
    {
        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public int Id { get; set; }


        //[ForeignKey("RoleId")]
        //public int RoleId { get; set; }
        //public virtual ICollection<Role> Roles { get; set; }

        //public int RoleId { get; set; }

        //[ForeignKey("EmpId")]
        //[Key]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        //[Key]
        public int RoleId { get; set; }
        public Role Role { get; set; }

       
    }
}
