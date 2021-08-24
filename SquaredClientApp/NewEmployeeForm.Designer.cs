
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
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lstRoles = new System.Windows.Forms.ListView();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSaveAddNew = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAddNewEmployee
            // 
            this.lblAddNewEmployee.AutoSize = true;
            this.lblAddNewEmployee.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddNewEmployee.Location = new System.Drawing.Point(214, 42);
            this.lblAddNewEmployee.Name = "lblAddNewEmployee";
            this.lblAddNewEmployee.Size = new System.Drawing.Size(216, 30);
            this.lblAddNewEmployee.TabIndex = 0;
            this.lblAddNewEmployee.Text = "Add New Employee";
            this.lblAddNewEmployee.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAddNewManager
            // 
            this.lblAddNewManager.AutoSize = true;
            this.lblAddNewManager.Location = new System.Drawing.Point(103, 99);
            this.lblAddNewManager.Name = "lblAddNewManager";
            this.lblAddNewManager.Size = new System.Drawing.Size(57, 15);
            this.lblAddNewManager.TabIndex = 7;
            this.lblAddNewManager.Text = "Manager:";
            // 
            // cboNewEmpManager
            // 
            this.cboNewEmpManager.FormattingEnabled = true;
            this.cboNewEmpManager.Location = new System.Drawing.Point(166, 91);
            this.cboNewEmpManager.Name = "cboNewEmpManager";
            this.cboNewEmpManager.Size = new System.Drawing.Size(324, 23);
            this.cboNewEmpManager.TabIndex = 3;
            this.cboNewEmpManager.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cboNewEmpManager_Format);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(93, 152);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(67, 15);
            this.lblFirstName.TabIndex = 9;
            this.lblFirstName.Text = "First Name:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(94, 192);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(66, 15);
            this.lblLastName.TabIndex = 10;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(122, 232);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(38, 15);
            this.lblRole.TabIndex = 11;
            this.lblRole.Text = "Roles:";
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(166, 149);
            this.txtFirstName.MaxLength = 50;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(324, 23);
            this.txtFirstName.TabIndex = 6;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(166, 189);
            this.txtLastName.MaxLength = 50;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(324, 23);
            this.txtLastName.TabIndex = 9;
            // 
            // lstRoles
            // 
            this.lstRoles.CheckBoxes = true;
            this.lstRoles.HideSelection = false;
            this.lstRoles.Location = new System.Drawing.Point(166, 232);
            this.lstRoles.Name = "lstRoles";
            this.lstRoles.Size = new System.Drawing.Size(324, 110);
            this.lstRoles.TabIndex = 12;
            this.lstRoles.UseCompatibleStateImageBehavior = false;
            this.lstRoles.View = System.Windows.Forms.View.List;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(195, 363);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 23);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "&Save and Close";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSaveAddNew
            // 
            this.btnSaveAddNew.Location = new System.Drawing.Point(337, 363);
            this.btnSaveAddNew.Name = "btnSaveAddNew";
            this.btnSaveAddNew.Size = new System.Drawing.Size(118, 23);
            this.btnSaveAddNew.TabIndex = 21;
            this.btnSaveAddNew.Text = "S&ave and Add New";
            this.btnSaveAddNew.UseVisualStyleBackColor = true;
            this.btnSaveAddNew.Click += new System.EventHandler(this.btnSaveAddNew_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 453);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(575, 22);
            this.statusStrip1.TabIndex = 22;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // NewEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 475);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnSaveAddNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lstRoles);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblAddNewManager);
            this.Controls.Add(this.cboNewEmpManager);
            this.Controls.Add(this.lblAddNewEmployee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "NewEmployeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S-Squared Enterprises Personnel System";
            this.Load += new System.EventHandler(this.NewEmployeeForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddNewEmployee;
        private System.Windows.Forms.Label lblAddNewManager;
        private System.Windows.Forms.ComboBox cboNewEmpManager;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.ListView lstRoles;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSaveAddNew;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}