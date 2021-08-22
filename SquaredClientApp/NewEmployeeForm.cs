using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TylerTechClientApp.Entities;
using TylerTechClientApp.Models;
using TylerTechClientApp.Services;

namespace TylerTechClientApp
{
    public partial class NewEmployeeForm : Form
    {
        private readonly IEmployeeServiceRepo _employeeService;
        public NewEmployeeForm(IEmployeeServiceRepo employeeServiceRepo)
        {
            InitializeComponent();
            _employeeService = employeeServiceRepo ?? throw new ArgumentNullException(nameof(EmployeeServiceRepo));
        }

        private void NewEmployeeForm_Load(object sender, EventArgs e)
        {
            //Fill manager combo box selector 
            cboNewEmpManager.DataSource = _employeeService.GetManagerEmployees();
            cboNewEmpManager.DisplayMember = "FirstName";
            cboNewEmpManager.ValueMember = "Id";

            
            //Fill the listView with roles
            foreach(var roleItem in _employeeService.GetAllRoles().ToList())
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
            AddEmployeeRoles(AddEmployee());
            this.Close();
        }

        /// <summary>
        /// Saves and prepares the form for new entry
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveAddNew_Click(object sender, EventArgs e)
        {
            AddEmployeeRoles(AddEmployee());
            ClearInputFields();
            cboNewEmpManager.Focus();
        }

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
        /// Add Employee resource first so we get the new employee id
        /// </summary>
        /// <returns>New employee Id generated</returns>
        private int AddEmployee()
        {
            //instantiate new employee
            Employee newEmployee = new Employee
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                ReportsTo = (int)cboNewEmpManager.SelectedValue,
            };

            //Get new created employeeid
            return _employeeService.AddEmployee(newEmployee);
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
