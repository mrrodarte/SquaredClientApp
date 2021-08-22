using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TylerTechClientApp.Contexts;
using TylerTechClientApp.Entities;
using TylerTechClientApp.Models;
using TylerTechClientApp.Services;

namespace TylerTechClientApp
{
    public partial class EmployeeMaintenance : Form
    {
        private readonly IEmployeeServiceRepo _employeeService;

        //Inject dependency employee repository
        public EmployeeMaintenance(IEmployeeServiceRepo employeeServiceRepo)
        {
            InitializeComponent();
            _employeeService = employeeServiceRepo ?? throw new ArgumentNullException(nameof(employeeServiceRepo));
        }

        //Load the initial form and data
        private void Form1_Load(object sender, EventArgs e)
        {
            cboEmployees.DataSource = _employeeService.GetManagerEmployees();
            cboEmployees.DisplayMember = "FirstName";
            cboEmployees.ValueMember = "Id";

            toolTip1.SetToolTip(btnRefresh, "Refresh Data");
        }

        //Format the employee combo box to display employee like LastName, FirstName
        private void cboEmployees_Format(object sender, ListControlConvertEventArgs e)
        {
            string firstName = ((EmployeeToDisplay)e.ListItem).FirstName;
            string lastName = ((EmployeeToDisplay)e.ListItem).LastName;

            e.Value = lastName + ", " + firstName;
        }

        //When selection changes fetch new detail data to employee grid
        private void cboEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            grdEmployees.DataSource = _employeeService.GetEmployeesByManager(((EmployeeToDisplay)cboEmployees.SelectedItem).Id).ToList();
        }

        private void btnAddNewEmp_Click(object sender, EventArgs e)
        {
            NewEmployeeForm newEmployeeForm = new NewEmployeeForm(_employeeService);
            newEmployeeForm.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cboEmployees.DataSource = _employeeService.GetManagerEmployees();
        }
    }
}
