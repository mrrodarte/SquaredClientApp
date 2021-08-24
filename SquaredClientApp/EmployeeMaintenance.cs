using System;
using System.Linq;
using System.Windows.Forms;
using SquaredClientApp.Models;
using SquaredClientApp.Services;
using SquaredClientApp.Shared;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using System.Threading;

namespace SquaredClientApp
{
    public partial class EmployeeMaintenance : Form
    {
        private readonly IEmployeeServiceRepo _employeeService;
        static ILogger _logger;

        //Inject dependency employee repository
        public EmployeeMaintenance(IEmployeeServiceRepo employeeServiceRepo, ILogger<EmployeeMaintenance> logger)
        {
            InitializeComponent();
            _employeeService = employeeServiceRepo ?? throw new ArgumentNullException(nameof(employeeServiceRepo));
            _logger = logger;
        }

        //Load the initial form and data
        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(btnRefresh, "Refresh Data");

            cboEmployees.DataSource = _employeeService.GetManagerEmployees();
            cboEmployees.DisplayMember = "FirstName";
            cboEmployees.ValueMember = "Id";            
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
            var newForm = GetNewService.GetRequiredService<NewEmployeeForm>();
            newForm.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cboEmployees.DataSource = _employeeService.GetManagerEmployees();
        }

        //we will handle all forms UI thread unhandled exceptions here to log them in one place
        public static void HandleUIThreadException(object sender, ThreadExceptionEventArgs t)
        {
            MessageBox.Show("Errors occurred check the log details or contact support.", "S-Squared", MessageBoxButtons.OK, MessageBoxIcon.Error);
            _logger.LogError(t.Exception, "Errors occurred check the log details.");
            Application.Exit();
        }
    }
}
