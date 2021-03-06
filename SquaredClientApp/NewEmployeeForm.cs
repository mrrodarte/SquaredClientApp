using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Extensions.Logging;
using SquaredClientApp.Entities;
using SquaredClientApp.Models;
using SquaredClientApp.Services;
using SquaredClientApp.Interfaces;

namespace SquaredClientApp
{
    public partial class NewEmployeeForm : Form
    {
        private readonly IEmployeeServiceRepo _employeeService;
        private readonly ILogger _logger;

        public NewEmployeeForm(IEmployeeServiceRepo employeeServiceRepo,
                                ILogger<NewEmployeeForm> logger)
        {
            InitializeComponent();
            _employeeService = employeeServiceRepo ?? throw new ArgumentNullException(nameof(EmployeeServiceRepo));
            _logger = logger;
        }

        //public property to preserve the manager selection when adding new employees
        public int selectedEmployeeIndex { get; set; }

        private void NewEmployeeForm_Load(object sender, EventArgs e)
        {
            //Fill manager combo box selector 
            cboNewEmpManager.DataSource = _employeeService.GetManagerEmployees();
            cboNewEmpManager.DisplayMember = "FirstName";
            cboNewEmpManager.ValueMember = "Id";
            cboNewEmpManager.SelectedIndex = this.selectedEmployeeIndex;

            //Fill the listView with roles
            foreach (var roleItem in _employeeService.GetAllRoles().ToList())
            {
                ListViewItem lvItem = new ListViewItem();
                lvItem.Text = roleItem.RoleDescription;
                lvItem.Tag = roleItem.RoleId;

                //we can pass more complex object in tag for more than one value
                //new Dictionary<int, bool>()
                //    {
                //        { roleItem.RoleId,roleItem.IsManagerRole }
                //    };

                lstRoles.Items.Add(lvItem);
            }

            cboNewEmpManager.Focus();
        }

        private void cboNewEmpManager_Format(object sender, ListControlConvertEventArgs e)
        {
            string firstName = ((EmployeeToDisplay)e.ListItem).FirstName;
            string lastName = ((EmployeeToDisplay)e.ListItem).LastName;

            e.Value = lastName + ", " + firstName;
        }

        /// <summary>
        /// Saves and closes the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            int employeeId;
            
            employeeId = AddEmployee();

            if (employeeId > 0) 
            {
                AddEmployeeRoles(employeeId);
                this.Close();
            }
        }

        /// <summary>
        /// Saves and prepares the form for new entry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveAddNew_Click(object sender, EventArgs e)
        {
            int employeeId;
            
            employeeId = AddEmployee();

            if (employeeId > 0)
            {
                AddEmployeeRoles(employeeId);
                ClearInputFields();

                toolStripStatusLabel1.Text = "Record Added Successfully.";

                cboNewEmpManager.Focus();
            }
        }

        /// <summary>
        /// Clears the input fields for a new entry.
        /// </summary>
        private void ClearInputFields()
        {
            cboNewEmpManager.SelectedIndex = 1;
            txtFirstName.Text = String.Empty;
            txtLastName.Text = string.Empty;
            
            //Deselect Roles
            foreach(ListViewItem item in lstRoles.CheckedItems)
            {
                item.Checked = false;
            }
        }

        /// <summary>
        /// Adds a new employee resource.
        /// </summary>
        /// <returns>The employee id of the newly created resource.</returns>
        private int AddEmployee()
        {
            //Validate fields
            if (!ValidateData())
                return 0;

            //instantiate new employee class
            Employee newEmployee = new Employee
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                ReportsTo = (int?)cboNewEmpManager.SelectedValue,
            };

            //Add and return the new employee id
            return _employeeService.AddEmployee(newEmployee);
        }

        /// <summary>
        /// Validate entry data.
        /// </summary>
        /// <returns></returns>
        private bool ValidateData()
        {
            if (string.IsNullOrEmpty(txtFirstName.Text.Trim()))
            {
                toolStripStatusLabel1.Text = "First Name field for employee cannot be empty.";
                txtFirstName.Focus();
                return false;
            }
            
            if (string.IsNullOrEmpty(txtLastName.Text.Trim()))
            {
                toolStripStatusLabel1.Text = "Last Name field for employee cannot be empty.";
                txtLastName.Focus();
                return false;
            }

            if (lstRoles.CheckedItems.Count <= 0)
            {
                toolStripStatusLabel1.Text = "You have to at least select one role.";
                lstRoles.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// Add Employee Roles for the created Employee
        /// </summary>
        /// <param name="empId"></param>
        private void AddEmployeeRoles(int empId)
        {
            List<EmployeeRole> employeeRoles = new List<EmployeeRole>();

            foreach (ListViewItem roleItem in lstRoles.CheckedItems)
            {
                EmployeeRole empRole = new EmployeeRole
                {
                    EmployeeId = empId,
                    RoleId = (int)roleItem.Tag
                };
                employeeRoles.Add(empRole);
            }

            //Add the employee roles
            _employeeService.AddEmployeeRoles(employeeRoles.ToArray());
        }
    }
}
