namespace FunPro.CW2._12938
{
    partial class SwipesAddForm
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
            this.cbxEmployeeName = new System.Windows.Forms.ComboBox();
            this.ememployeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.dtpSwipeDate = new System.Windows.Forms.DateTimePicker();
            this.lblSwipeDate = new System.Windows.Forms.Label();
            this.lblSwipeIn = new System.Windows.Forms.Label();
            this.lblSwipeOut = new System.Windows.Forms.Label();
            this.dtpSwipeIn = new System.Windows.Forms.DateTimePicker();
            this.dtpSwipeOut = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ememployeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxEmployeeName
            // 
            this.cbxEmployeeName.DataSource = this.ememployeeBindingSource;
            this.cbxEmployeeName.DisplayMember = "Name";
            this.cbxEmployeeName.FormattingEnabled = true;
            this.cbxEmployeeName.Location = new System.Drawing.Point(184, 15);
            this.cbxEmployeeName.Name = "cbxEmployeeName";
            this.cbxEmployeeName.Size = new System.Drawing.Size(130, 21);
            this.cbxEmployeeName.TabIndex = 0;
            this.cbxEmployeeName.ValueMember = "Id";
            // 
            // ememployeeBindingSource
            // 
            this.ememployeeBindingSource.DataSource = typeof(FunPro.CW2.DAL.em_employee);
            // 
            // lblEmployeeName
            // 
            this.lblEmployeeName.AutoSize = true;
            this.lblEmployeeName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeName.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEmployeeName.Location = new System.Drawing.Point(12, 9);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(169, 25);
            this.lblEmployeeName.TabIndex = 6;
            this.lblEmployeeName.Text = "Employee Name";
            // 
            // dtpSwipeDate
            // 
            this.dtpSwipeDate.CustomFormat = "dd.MM.yyyy";
            this.dtpSwipeDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSwipeDate.Location = new System.Drawing.Point(184, 57);
            this.dtpSwipeDate.Name = "dtpSwipeDate";
            this.dtpSwipeDate.Size = new System.Drawing.Size(130, 20);
            this.dtpSwipeDate.TabIndex = 1;
            // 
            // lblSwipeDate
            // 
            this.lblSwipeDate.AutoSize = true;
            this.lblSwipeDate.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSwipeDate.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSwipeDate.Location = new System.Drawing.Point(12, 52);
            this.lblSwipeDate.Name = "lblSwipeDate";
            this.lblSwipeDate.Size = new System.Drawing.Size(120, 25);
            this.lblSwipeDate.TabIndex = 7;
            this.lblSwipeDate.Text = "Swipe Date";
            // 
            // lblSwipeIn
            // 
            this.lblSwipeIn.AutoSize = true;
            this.lblSwipeIn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSwipeIn.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSwipeIn.Location = new System.Drawing.Point(12, 111);
            this.lblSwipeIn.Name = "lblSwipeIn";
            this.lblSwipeIn.Size = new System.Drawing.Size(94, 25);
            this.lblSwipeIn.TabIndex = 8;
            this.lblSwipeIn.Text = "Swipe in";
            // 
            // lblSwipeOut
            // 
            this.lblSwipeOut.AutoSize = true;
            this.lblSwipeOut.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSwipeOut.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblSwipeOut.Location = new System.Drawing.Point(12, 170);
            this.lblSwipeOut.Name = "lblSwipeOut";
            this.lblSwipeOut.Size = new System.Drawing.Size(112, 25);
            this.lblSwipeOut.TabIndex = 9;
            this.lblSwipeOut.Text = "Swipe Out";
            // 
            // dtpSwipeIn
            // 
            this.dtpSwipeIn.CustomFormat = "HH:mm";
            this.dtpSwipeIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSwipeIn.Location = new System.Drawing.Point(184, 114);
            this.dtpSwipeIn.Name = "dtpSwipeIn";
            this.dtpSwipeIn.ShowUpDown = true;
            this.dtpSwipeIn.Size = new System.Drawing.Size(130, 20);
            this.dtpSwipeIn.TabIndex = 2;
            this.dtpSwipeIn.Value = new System.DateTime(2023, 3, 5, 9, 0, 0, 0);
            // 
            // dtpSwipeOut
            // 
            this.dtpSwipeOut.CustomFormat = "HH:mm";
            this.dtpSwipeOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSwipeOut.Location = new System.Drawing.Point(184, 173);
            this.dtpSwipeOut.Name = "dtpSwipeOut";
            this.dtpSwipeOut.ShowUpDown = true;
            this.dtpSwipeOut.Size = new System.Drawing.Size(130, 20);
            this.dtpSwipeOut.TabIndex = 3;
            this.dtpSwipeOut.Value = new System.DateTime(2023, 3, 5, 18, 0, 0, 0);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(178, 238);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(136, 45);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSave.Location = new System.Drawing.Point(12, 238);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(136, 45);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // SwipesAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 334);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dtpSwipeOut);
            this.Controls.Add(this.dtpSwipeIn);
            this.Controls.Add(this.lblSwipeOut);
            this.Controls.Add(this.lblSwipeIn);
            this.Controls.Add(this.dtpSwipeDate);
            this.Controls.Add(this.lblSwipeDate);
            this.Controls.Add(this.lblEmployeeName);
            this.Controls.Add(this.cbxEmployeeName);
            this.Name = "SwipesAddForm";
            this.Text = "Add new Swipe";
            this.Load += new System.EventHandler(this.SwipesAddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ememployeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxEmployeeName;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.DateTimePicker dtpSwipeDate;
        private System.Windows.Forms.Label lblSwipeDate;
        private System.Windows.Forms.Label lblSwipeIn;
        private System.Windows.Forms.Label lblSwipeOut;
        private System.Windows.Forms.DateTimePicker dtpSwipeIn;
        private System.Windows.Forms.DateTimePicker dtpSwipeOut;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.BindingSource ememployeeBindingSource;
    }
}