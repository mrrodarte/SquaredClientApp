
namespace TylerTechClientApp
{
    partial class EmployeeMaintenance
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cboEmployees = new System.Windows.Forms.ComboBox();
            this.grdEmployees = new System.Windows.Forms.DataGridView();
            this.btnAddNewEmp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 4;
            // 
            // cboEmployees
            // 
            this.cboEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmployees.FormattingEnabled = true;
            this.cboEmployees.Location = new System.Drawing.Point(212, 69);
            this.cboEmployees.Name = "cboEmployees";
            this.cboEmployees.Size = new System.Drawing.Size(324, 23);
            this.cboEmployees.TabIndex = 1;
            this.cboEmployees.SelectedIndexChanged += new System.EventHandler(this.cboEmployees_SelectedIndexChanged);
            this.cboEmployees.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cboEmployees_Format);
            // 
            // grdEmployees
            // 
            this.grdEmployees.AllowUserToAddRows = false;
            this.grdEmployees.AllowUserToDeleteRows = false;
            this.grdEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdEmployees.Location = new System.Drawing.Point(124, 146);
            this.grdEmployees.Name = "grdEmployees";
            this.grdEmployees.ReadOnly = true;
            this.grdEmployees.RowTemplate.Height = 25;
            this.grdEmployees.Size = new System.Drawing.Size(449, 287);
            this.grdEmployees.TabIndex = 2;
            // 
            // btnAddNewEmp
            // 
            this.btnAddNewEmp.Location = new System.Drawing.Point(286, 455);
            this.btnAddNewEmp.Name = "btnAddNewEmp";
            this.btnAddNewEmp.Size = new System.Drawing.Size(109, 30);
            this.btnAddNewEmp.TabIndex = 3;
            this.btnAddNewEmp.Text = "Add Employee";
            this.btnAddNewEmp.UseVisualStyleBackColor = true;
            this.btnAddNewEmp.Click += new System.EventHandler(this.btnAddNewEmp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Manager:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackgroundImage = global::SquaredClientApp.Properties.Resources.cropped_Refresh_icon;
            this.btnRefresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRefresh.Location = new System.Drawing.Point(543, 68);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(30, 24);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // EmployeeMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 512);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAddNewEmp);
            this.Controls.Add(this.grdEmployees);
            this.Controls.Add(this.cboEmployees);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "EmployeeMaintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S-Squared Enterprises Personnel System";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboEmployees;
        private System.Windows.Forms.DataGridView grdEmployees;
        private System.Windows.Forms.Button btnAddNewEmp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

