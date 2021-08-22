using System;
using System.Collections.Generic;
using TylerTechClientApp.Entities;
using TylerTechClientApp.Models;

namespace TylerTechClientApp.Services
{
    /// <summary>
    /// This is the interface we will use to define our repo class.
    /// This enables us to decouple and use dependency injection
    /// </summary>
    public interface IEmployeeServiceRepo
    {
        List<EmployeeToDisplay> GetManagerEmployees();

        IEnumerable<EmployeeToDisplay> GetEmployeesByManager(int id);

        IEnumerable<Role> GetAllRoles();
        
        int AddEmployee(Employee employee);

        void AddEmployeeRoles(EmployeeRole[] employeeRole);
    }
}