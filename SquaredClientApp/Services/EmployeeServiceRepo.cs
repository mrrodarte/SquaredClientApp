using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SquaredClientApp.Contexts;
using SquaredClientApp.Entities;
using SquaredClientApp.Models;

namespace SquaredClientApp.Services
{
    /// <summary>
    /// This is the employee service class where you perform query operations to retrieve data
    /// </summary>
    public class EmployeeServiceRepo : IEmployeeServiceRepo
    {
        private readonly EmployeeContext _context;

        public EmployeeServiceRepo(EmployeeContext context)
        {
            _context = context ?? throw new ArgumentException(nameof(context));
        }

        public List<EmployeeToDisplay> GetManagerEmployees()
        {
            //This is what is to be fed to combobox selector
            //We need to include all relationships to get to the manager role flag
            //so we can filter and only display managers
            var Result = _context.Employees
                .Include(a => a.EmployeeRoles)
                .ThenInclude(x => x.Role)
                .SelectMany(er => er.EmployeeRoles)
                .Select(c => new EmployeeToDisplay
                {
                    Id = c.EmployeeId,
                    FirstName = c.Employee.FirstName,
                    LastName = c.Employee.LastName,
                    IsManagerRole = c.Role.IsManagerRole,
                    RoleDescription = c.Role.RoleDescription
                }).Where(i => i.IsManagerRole == true).ToList();

            return Result;

            //DEBUG this is to inspect each of the level values comment for production
            //var test2 = test.SelectMany(er => er.EmployeeRoles);

            //var test4 = test2.Select(c => new EmployeeToDisplay
            //{
            //    Id = c.EmployeeId,
            //    FirstName = c.Employee.FirstName,
            //    LastName = c.Employee.LastName,
            //    IsManagerRole = c.Role.IsManagerRole,
            //    RoleDescription = c.Role.RoleDescription
            //}).Where(i => i.IsManagerRole == true).ToList();

            //return _context.Employees.Include(a => a.EmployeeRoles)
            //                            .ThenInclude(x => x.Role).ToList();

        }

        public IEnumerable<EmployeeToDisplayGroup> GetEmployeesByManager(int id)
        {
            //return an empty list if no id is passed
            if (id == 0)
                return new List<EmployeeToDisplayGroup>();

            // This is the object that is to be displayed on grid, flattened with the necesary fields
            var Result = _context.Employees
                .Where(i => i.ReportsTo == id).Include(a => a.EmployeeRoles)
                .ThenInclude(x => x.Role)
                .SelectMany(er => er.EmployeeRoles)
                .Select(c => new EmployeeToDisplay
                {
                    Id = c.EmployeeId,
                    FirstName = c.Employee.FirstName,
                    LastName = c.Employee.LastName,
                    RoleDescription = c.Role.RoleDescription,
                })
                .AsEnumerable()
                .GroupBy(
                        e => new
                        {
                            e.Id,
                            e.FirstName,
                            e.LastName
                        },
                        e => e.RoleDescription,
                        (key, g) => new EmployeeToDisplayGroup 
                        {
                            Id = key.Id,
                            FirstName = key.FirstName,
                            LastName = key.LastName,
                            RoleDescription = string.Join(",", g.ToArray())
                        })
                .ToList();

            return Result; 
        }

        public IEnumerable<Role> GetAllRoles()
        {
            return _context.Roles.Select(c => new Role
            {
                RoleId = c.RoleId,
                RoleDescription = c.RoleDescription
            });
        }

        public int AddEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();

            return employee.EmployeeId;
        }

        public void AddEmployeeRoles(EmployeeRole[] employeeRole)
        {
            _context.EmployeeRoles.AddRange(employeeRole);
            _context.SaveChangesAsync();
        }
    }
}
