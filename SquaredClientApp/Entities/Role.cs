using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace SquaredClientApp.Entities
{
    public class Role
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoleId { get; set; }

        [DefaultValue(false)]
        public bool IsManagerRole { get; set; }

        [MaxLength(100)]
        public string RoleDescription { get; set; }

        public ICollection<EmployeeRole> EmployeeRoles { get; set; }
    }
}
