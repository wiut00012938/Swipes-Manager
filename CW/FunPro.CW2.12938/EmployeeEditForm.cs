using FunPro.CW2._12938.DAL;
using FunPro.CW2.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FunPro.CW2._12938
{
    public partial class EmployeeEditForm : Form
    {
        public EmployeeEditForm()
        {
            InitializeComponent();
        }
        public em_employee em_employee { get; set; } //creaing initial data holder

        public FormMode Mode { get; set; } //initializing Mode class

        //creaing two different voids with different purposes
        public void CreateNewEmployee()
        {
            Mode = FormMode.CreateNew;
            em_employee = new em_employee();
            InitializeControls();
            MdiParent = MyForms.GetForm<ParentForm>();
            Show();
        }

        public void UpdateEmployee(em_employee Em_employee)
        {
            Mode = FormMode.Update;
            em_employee = Em_employee;
            InitializeControls();
            ShowEmployeeInControls();
            MdiParent = MyForms.GetForm<ParentForm>();
            Show();
        }

        private void InitializeControls()
        {
        }
        //ShowEmployeeInControls and GrabUserInput are used for taking imput and setting it to class properties. They are both-sided
        private void ShowEmployeeInControls()
        {
            tbxName.Text = em_employee.Name;
            chbIsActive.Checked = em_employee.IsActive;
            dtpStartDate.Value = em_employee.StartDate;
            dtpDischargeDate.Value = em_employee.DischargeDate;
        }

        private void GrabUserInput()
        {
            em_employee.Name = tbxName.Text;
            em_employee.IsActive = chbIsActive.Checked;
            em_employee.StartDate = dtpStartDate.Value;
            em_employee.DischargeDate = dtpDischargeDate.Value;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                GrabUserInput();
                var manager = new em_employee_manager();
                if (Mode == FormMode.CreateNew)
                    manager.Create(em_employee); //for first mode we use Create() method
                else
                    manager.Update(em_employee); // for second mode we use Update() method

                MyForms.GetForm<all_employees>().LoadData();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close(); // if user presses cancel, the form is closed
        }




        private void EmployeeEditForm_Load(object sender, EventArgs e)
        {
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }
        private void dtpDischargeDate_ValueChanged(object sender, EventArgs e)
        {
        }

    }
}
