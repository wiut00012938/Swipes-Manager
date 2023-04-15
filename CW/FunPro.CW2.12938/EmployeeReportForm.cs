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
    public partial class EmployeeReportForm : Form
    {
        public EmployeeReportForm()
        {
            InitializeComponent();
        }
        public sp_swipe sp_swipe { get; set; }
        public void LoadData()
        {
            dgv.DataMember = "";
            dgv.DataSource = null;
            dgv.DataSource = new EmployeeReportManager().GetAll();//For populating data we are calling class and GetAll()
            //formating for data Grid View using DefaultCellStyle property
            dgv.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgv.Columns[2].DefaultCellStyle.Format = "HH:mm";
            dgv.Columns[3].DefaultCellStyle.Format = "HH:mm";
            dgv.Columns[4].DefaultCellStyle.Format = "HH:mm";
            dgv.Columns[5].DefaultCellStyle.Format = "HH:mm";
        }


        
        private void InitializeControls()
        {
            cbxEmployee.DataSource = new em_employee_manager().GetAll(); //populating showing values for combobox
        }
        private void EmployeeReportForm_Load(object sender, EventArgs e)
        {
            //loading necessary data and showing it
            MdiParent = MyForms.GetForm<ParentForm>();
            LoadData();
            InitializeControls();
            Show();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (cbxEmployee.SelectedIndex < 0) //need to ensure whether a user selected combobox item
                MessageBox.Show("Select an Employee");
            else
            {

                dgv.DataMember = "";
                dgv.DataSource = null;
                //calling Searcing() that is iside manager for filtering by user's entered date and name(combobox shows names by gives use id of this name)
                var SearchData = new EmployeeReportManager().Searching(Convert.ToInt32(cbxEmployee.SelectedValue),Convert.ToDateTime(dtpMonth.Value));
                dgv.DataSource = SearchData;

                double Result = 0;
                //having filtered data and hours worked for some days, for finding total worked hours we just need to add them by creaing a loop
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    DataGridViewCell lastCell = dgv.Rows[i].Cells[dgv.Columns.Count-1];//hours worked column is last and it is constant. We need to change only row
                    Result += Convert.ToDouble(lastCell.Value);
                }
                lblTotalHoursIndecator.Text = Result.ToString();
                if(Result < 176) // for one month a worker should work minimum 176 hours, if total hours will be less messagebox is showed
                {
                    MessageBox.Show("Total Worked Hours by Selected Employee is less than settled minimum(176 hours per month)");
                }
            }
        }

        
        
        
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
