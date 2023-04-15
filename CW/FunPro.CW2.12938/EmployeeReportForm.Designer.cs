namespace FunPro.CW2._12938
{
    partial class EmployeeReportForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxEmployee = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.dtpMonth = new System.Windows.Forms.DateTimePicker();
            this.lblTotalHoursIndecator = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.outDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roundedInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roundedOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoursWorkedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ememployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ememployeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(23, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 33);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total hours:";
            // 
            // cbxEmployee
            // 
            this.cbxEmployee.DataSource = this.ememployeeBindingSource;
            this.cbxEmployee.DisplayMember = "Name";
            this.cbxEmployee.FormattingEnabled = true;
            this.cbxEmployee.Location = new System.Drawing.Point(159, 28);
            this.cbxEmployee.Name = "cbxEmployee";
            this.cbxEmployee.Size = new System.Drawing.Size(121, 21);
            this.cbxEmployee.TabIndex = 3;
            this.cbxEmployee.ValueMember = "Id";
            this.cbxEmployee.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(23, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Month";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(159, 94);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(121, 37);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Generate a report";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // dtpMonth
            // 
            this.dtpMonth.CustomFormat = "MMMM yyyy";
            this.dtpMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpMonth.Location = new System.Drawing.Point(159, 68);
            this.dtpMonth.Name = "dtpMonth";
            this.dtpMonth.ShowUpDown = true;
            this.dtpMonth.Size = new System.Drawing.Size(121, 20);
            this.dtpMonth.TabIndex = 8;
            // 
            // lblTotalHoursIndecator
            // 
            this.lblTotalHoursIndecator.AutoSize = true;
            this.lblTotalHoursIndecator.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalHoursIndecator.Location = new System.Drawing.Point(189, 408);
            this.lblTotalHoursIndecator.Name = "lblTotalHoursIndecator";
            this.lblTotalHoursIndecator.Size = new System.Drawing.Size(0, 33);
            this.lblTotalHoursIndecator.TabIndex = 10;
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AutoGenerateColumns = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.inDataGridViewTextBoxColumn,
            this.outDataGridViewTextBoxColumn,
            this.roundedInDataGridViewTextBoxColumn,
            this.roundedOutDataGridViewTextBoxColumn,
            this.hoursWorkedDataGridViewTextBoxColumn});
            this.dgv.DataSource = this.employeeReportBindingSource;
            this.dgv.Location = new System.Drawing.Point(12, 137);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(767, 268);
            this.dgv.TabIndex = 11;
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inDataGridViewTextBoxColumn
            // 
            this.inDataGridViewTextBoxColumn.DataPropertyName = "In";
            this.inDataGridViewTextBoxColumn.HeaderText = "In";
            this.inDataGridViewTextBoxColumn.Name = "inDataGridViewTextBoxColumn";
            this.inDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // outDataGridViewTextBoxColumn
            // 
            this.outDataGridViewTextBoxColumn.DataPropertyName = "Out";
            this.outDataGridViewTextBoxColumn.HeaderText = "Out";
            this.outDataGridViewTextBoxColumn.Name = "outDataGridViewTextBoxColumn";
            this.outDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roundedInDataGridViewTextBoxColumn
            // 
            this.roundedInDataGridViewTextBoxColumn.DataPropertyName = "RoundedIn";
            this.roundedInDataGridViewTextBoxColumn.HeaderText = "Rounded In";
            this.roundedInDataGridViewTextBoxColumn.Name = "roundedInDataGridViewTextBoxColumn";
            this.roundedInDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roundedOutDataGridViewTextBoxColumn
            // 
            this.roundedOutDataGridViewTextBoxColumn.DataPropertyName = "RoundedOut";
            this.roundedOutDataGridViewTextBoxColumn.HeaderText = "Rounded Out";
            this.roundedOutDataGridViewTextBoxColumn.Name = "roundedOutDataGridViewTextBoxColumn";
            this.roundedOutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hoursWorkedDataGridViewTextBoxColumn
            // 
            this.hoursWorkedDataGridViewTextBoxColumn.DataPropertyName = "HoursWorked";
            this.hoursWorkedDataGridViewTextBoxColumn.HeaderText = "Hours Worked";
            this.hoursWorkedDataGridViewTextBoxColumn.Name = "hoursWorkedDataGridViewTextBoxColumn";
            this.hoursWorkedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeReportBindingSource
            // 
            this.employeeReportBindingSource.DataSource = typeof(FunPro.CW2._12938.DAL.EmployeeReport);
            // 
            // ememployeeBindingSource
            // 
            this.ememployeeBindingSource.DataSource = typeof(FunPro.CW2.DAL.em_employee);
            // 
            // EmployeeReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 450);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.lblTotalHoursIndecator);
            this.Controls.Add(this.dtpMonth);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxEmployee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "EmployeeReportForm";
            this.Text = "EmployeeReportForm";
            this.Load += new System.EventHandler(this.EmployeeReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ememployeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.DateTimePicker dtpMonth;
        private System.Windows.Forms.Label lblTotalHoursIndecator;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.BindingSource employeeReportBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn outDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roundedInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roundedOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoursWorkedDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ememployeeBindingSource;
    }
}