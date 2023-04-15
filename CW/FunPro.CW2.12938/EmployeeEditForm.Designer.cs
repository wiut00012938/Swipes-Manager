namespace FunPro.CW2._12938
{
    partial class EmployeeEditForm
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
            this.tbxName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.chbIsActive = new System.Windows.Forms.CheckBox();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblDischargeDate = new System.Windows.Forms.Label();
            this.dtpDischargeDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // tbxName
            // 
            this.tbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbxName.Location = new System.Drawing.Point(179, 9);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(135, 23);
            this.tbxName.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSave.Location = new System.Drawing.Point(12, 235);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(136, 45);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(178, 235);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(136, 45);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblStartDate.Location = new System.Drawing.Point(12, 106);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(109, 25);
            this.lblStartDate.TabIndex = 7;
            this.lblStartDate.Text = "Start Date";
            // 
            // chbIsActive
            // 
            this.chbIsActive.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chbIsActive.Font = new System.Drawing.Font("Microsoft JhengHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbIsActive.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.chbIsActive.Location = new System.Drawing.Point(9, 48);
            this.chbIsActive.Name = "chbIsActive";
            this.chbIsActive.Size = new System.Drawing.Size(260, 37);
            this.chbIsActive.TabIndex = 1;
            this.chbIsActive.Text = "Is Active";
            this.chbIsActive.UseVisualStyleBackColor = true;
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEmployeeName.Location = new System.Drawing.Point(4, 9);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(169, 25);
            this.lblEmployeeName.TabIndex = 6;
            this.lblEmployeeName.Text = "Employee Name";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "yyyy-MM-dd";
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(184, 111);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(130, 20);
            this.dtpStartDate.TabIndex = 2;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblDischargeDate
            // 
            this.lblDischargeDate.AutoSize = true;
            this.lblDischargeDate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDischargeDate.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDischargeDate.Location = new System.Drawing.Point(12, 153);
            this.lblDischargeDate.Name = "lblDischargeDate";
            this.lblDischargeDate.Size = new System.Drawing.Size(158, 25);
            this.lblDischargeDate.TabIndex = 8;
            this.lblDischargeDate.Text = "Discharge Date";
            // 
            // dtpDischargeDate
            // 
            this.dtpDischargeDate.CustomFormat = "yyyy-MM-dd";
            this.dtpDischargeDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDischargeDate.Location = new System.Drawing.Point(184, 158);
            this.dtpDischargeDate.Name = "dtpDischargeDate";
            this.dtpDischargeDate.Size = new System.Drawing.Size(130, 20);
            this.dtpDischargeDate.TabIndex = 3;
            this.dtpDischargeDate.Value = new System.DateTime(2050, 1, 1, 0, 0, 0, 0);
            this.dtpDischargeDate.ValueChanged += new System.EventHandler(this.dtpDischargeDate_ValueChanged);
            // 
            // EmployeeEditForm
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(344, 326);
            this.Controls.Add(this.dtpDischargeDate);
            this.Controls.Add(this.lblDischargeDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.chbIsActive);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tbxName);
            this.Name = "EmployeeEditForm";
            this.Text = "Edit Employee";
            this.Load += new System.EventHandler(this.EmployeeEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.CheckBox chbIsActive;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblDischargeDate;
        private System.Windows.Forms.DateTimePicker dtpDischargeDate;
    }
}