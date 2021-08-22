using System;
using System.Collections.Generic;
using SquaredClientApp.Entities;
using SquaredClientApp.Models;

namespace SquaredClientApp.Services
{
    /// <summary>
    /// This is the interface we will use to define our repo class.
    /// This enables us to decouple and use dependency injection
    /// </summary>
    public interface IEmployeeServiceRepo
    {
        List<EmployeeToDisplay> GetManagerEmployees();

        IEnumerable<EmployeeToDisplayGroup> GetEmployeesByManager(int id);

        IEnumerable<Role> GetAllRoles();
        
        int AddEmployee(Employee employee);

        void AddEmployeeRoles(EmployeeRole[] employeeRole);
    }
}