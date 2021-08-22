using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using Microsoft.EntityFrameworkCore;
using TylerTechClientApp.Entities;

namespace TylerTechClientApp.Contexts
{
    public class EmployeeContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<EmployeeRole> EmployeeRoles { get; set; }
        public EmployeeContext(DbContextOptions<EmployeeContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //****set relationships and keys ****
            //Was done in this section instead of data annotations since the relationships are
            //more complex and include 3 entities

            modelBuilder.Entity<EmployeeRole>()
                .HasKey(er => new { er.EmployeeId, er.RoleId });

            modelBuilder.Entity<EmployeeRole>()
                .HasOne<Employee>(c => c.Employee)
                .WithMany(g => g.EmployeeRoles)
                .HasForeignKey(f => f.EmployeeId);

            modelBuilder.Entity<EmployeeRole>()
                .HasOne<Role>(c => c.Role)
                .WithMany(g => g.EmployeeRoles)
                .HasForeignKey(f => f.RoleId);

            //seed/populate the data
            modelBuilder.Entity<Employee>()
                .HasData(
                    new Employee()
                    {
                        EmployeeId = 1,
                        FirstName = "Mario",
                        LastName = "Rodarte"
                        //RoleId = 1,
                        //IsManager=true
                    },
                    new Employee()
                    {
                        EmployeeId = 2,
                        FirstName = "Steve",
                        LastName = "Smith",
                        ReportsTo = 3
                        //RoleId = 2,
                    },
                    new Employee()
                    {
                        EmployeeId = 3,
                        FirstName = "Jaqueline",
                        LastName = "Brown",
                        ReportsTo = 1
                        //RoleId = 4,
                    }
                );

            modelBuilder.Entity<Role>()
                .HasData(
                    new Role
                    {
                        RoleId = 1,
                        IsManagerRole=true,
                        RoleDescription = "Director"
                    },
                    new Role
                    {
                        RoleId = 2,
                        IsManagerRole=false,
                        RoleDescription = "Accounting"
                    },
                    new Role
                    {
                        RoleId = 3,
                        IsManagerRole=false,
                        RoleDescription = "Sales"
                    },
                    new Role
                    {
                        RoleId = 4,
                        IsManagerRole=false,
                        RoleDescription = "IT"
                    },
                    new Role
                    {
                        RoleId = 5,
                        IsManagerRole=false,
                        RoleDescription = "Analyst"
                    },
                    new Role
                    {
                        RoleId = 6,
                        IsManagerRole=false,
                        RoleDescription = "Support"
                    }
                );

            modelBuilder.Entity<EmployeeRole>()
                .HasData(
                    new EmployeeRole
                    {
                        EmployeeId=1,
                        RoleId=1
                    },
                    new EmployeeRole
                    {
                        EmployeeId=2,
                        RoleId = 6
                    },
                    new EmployeeRole
                    {
                        EmployeeId=3,
                        RoleId = 1
                    }
                );
        }
    }
}
