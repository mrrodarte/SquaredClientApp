using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TylerTechClientApp.Contexts;
using TylerTechClientApp.Entities;
using TylerTechClientApp.Models;

namespace TylerTechClientApp.Services
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
            var Result = _context.Employees.Include(a => a.EmployeeRoles)
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

        public IEnumerable<EmployeeToDisplay> GetEmployeesByManager(int id)
        {
            //return an empty list if no id is passed
            if (id == 0)
                return new List<EmployeeToDisplay>();

            var Result = _context.Employees.Where(i => i.ReportsTo == id).Include(a => a.EmployeeRoles)
                                        .ThenInclude(x => x.Role)
                                        .SelectMany(er => er.EmployeeRoles)
                                        .Select(c => new EmployeeToDisplay
                                        {
                                            Id = c.EmployeeId,
                                            FirstName = c.Employee.FirstName,
                                            LastName = c.Employee.LastName,
                                            RoleDescription = c.Role.RoleDescription,
                                            IsManagerRole = c.Role.IsManagerRole
                                        }).ToList();

            //left this commented for testing reference
            //IEnumerable<Employee> rawEmployeeList = _context.Employees.Include(c => c.Role).Where(c => c.ReportsTo == id).ToList();

            //IEnumerable<EmployeeToDisplay> employeeResult = rawEmployeeList
            //                                .Select(emp => new EmployeeToDisplay 
            //                                {
            //                                    Id = emp.Id, 
            //                                    LastName =  emp.LastName,
            //                                    FirstName = emp.FirstName, 
            //                                    RoleDescription = emp.Role.RoleDescription 
            //                                }).ToList();

            return Result; //new List<EmployeeToDisplay>();//employeeResult;
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

            //employee.EmployeeRoles.Add(new EmployeeRole
            //{
            //    EmployeeId = employee.EmployeeId,
            //    RoleId=1
            //});

            //_context.Employees.Add(employee);
        }

        public void AddEmployeeRoles(EmployeeRole[] employeeRole)
        {
            _context.EmployeeRoles.AddRange(employeeRole);
            _context.SaveChangesAsync();
        }
    }
}
