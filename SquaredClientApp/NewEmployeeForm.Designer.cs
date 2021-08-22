
namespace SquaredClientApp
{
    partial class NewEmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAddNewEmployee = new System.Windows.Forms.Label();
            this.lblAddNewManager = new System.Windows.Forms.Label();
            this.cboNewEmpManager = new System.Windows.Forms.ComboBox();
            this.lblEmpId = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lstRoles = new System.Windows.Forms.ListView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSaveAddNew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddNewEmployee
            // 
            this.lblAddNewEmployee.AutoSize = true;
            this.lblAddNewEmployee.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddNewEmployee.Location = new System.Drawing.Point(206, 64);
            this.lblAddNewEmployee.Name = "lblAddNewEmployee";
            this.lblAddNewEmployee.Size = new System.Drawing.Size(216, 30);
            this.lblAddNewEmployee.TabIndex = 0;
            this.lblAddNewEmployee.Text = "Add New Employee";
            this.lblAddNewEmployee.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAddNewManager
            // 
            this.lblAddNewManager.AutoSize = true;
            this.lblAddNewManager.Location = new System.Drawing.Point(95, 121);
            this.lblAddNewManager.Name = "lblAddNewManager";
            this.lblAddNewManager.Size = new System.Drawing.Size(57, 15);
            this.lblAddNewManager.TabIndex = 7;
            this.lblAddNewManager.Text = "Manager:";
            // 
            // cboNewEmpManager
            // 
            this.cboNewEmpManager.FormattingEnabled = true;
            this.cboNewEmpManager.Location = new System.Drawing.Point(158, 113);
            this.cboNewEmpManager.Name = "cboNewEmpManager";
            this.cboNewEmpManager.Size = new System.Drawing.Size(324, 23);
            this.cboNewEmpManager.TabIndex = 3;
            this.cboNewEmpManager.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cboNewEmpManager_Format);
            // 
            // lblEmpId
            // 
            this.lblEmpId.AutoSize = true;
            this.lblEmpId.Location = new System.Drawing.Point(76, 182);
            this.lblEmpId.Name = "lblEmpId";
            this.lblEmpId.Size = new System.Drawing.Size(76, 15);
            this.lblEmpId.TabIndex = 8;
            this.lblEmpId.Text = "Employee ID:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(85, 222);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(67, 15);
            this.lblFirstName.TabIndex = 9;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(86, 262);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(66, 15);
            this.lblLastName.TabIndex = 10;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(114, 302);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(38, 15);
            this.lblRole.TabIndex = 11;
            this.lblRole.Text = "Roles:";
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtEmployeeId.Enabled = false;
            this.txtEmployeeId.Location = new System.Drawing.Point(158, 179);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(63, 23);
            this.txtEmployeeId.TabIndex = 20;
            this.txtEmployeeId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(158, 219);
            this.txtFirstName.MaxLength = 50;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(324, 23);
            this.txtFirstName.TabIndex = 6;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(158, 259);
            this.txtLastName.MaxLength = 50;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(324, 23);
            this.txtLastName.TabIndex = 9;
            // 
            // lstRoles
            // 
            this.lstRoles.CheckBoxes = true;
            this.lstRoles.HideSelection = false;
            this.lstRoles.Location = new System.Drawing.Point(158, 302);
            this.lstRoles.Name = "lstRoles";
            this.lstRoles.Size = new System.Drawing.Size(324, 110);
            this.lstRoles.TabIndex = 12;
            this.lstRoles.UseCompatibleStateImageBehavior = false;
            this.lstRoles.View = System.Windows.Forms.View.List;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(187, 435);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "&Save and Close";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSaveAddNew
            // 
            this.btnSaveAddNew.Location = new System.Drawing.Point(329, 435);
            this.btnSaveAddNew.Name = "btnSaveAddNew";
            this.btnSaveAddNew.Size = new System.Drawing.Size(118, 23);
            this.btnSaveAddNew.TabIndex = 21;
            this.btnSaveAddNew.Text = "S&ave and Add New";
            this.btnSaveAddNew.UseVisualStyleBackColor = true;
            this.btnSaveAddNew.Click += new System.EventHandler(this.btnSaveAddNew_Click);
            // 
            // NewEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 502);
            this.Controls.Add(this.btnSaveAddNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lstRoles);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.txtEmployeeId);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblEmpId);
            this.Controls.Add(this.lblAddNewManager);
            this.Controls.Add(this.cboNewEmpManager);
            this.Controls.Add(this.lblAddNewEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "NewEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S-Squared Enterprises Personnel System";
            this.Load += new System.EventHandler(this.NewEmployeeForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddNewEmployee;
        private System.Windows.Forms.Label lblAddNewManager;
        private System.Windows.Forms.ComboBox cboNewEmpManager;
        private System.Windows.Forms.Label lblEmpId;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.ListView lstRoles;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSaveAddNew;
    }
}