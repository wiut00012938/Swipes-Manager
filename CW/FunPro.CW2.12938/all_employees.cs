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
    public partial class all_employees : Form
    {
        public all_employees()
        {
            InitializeComponent();
        }

        private void all_employees_Load(object sender, EventArgs e)
        {
            MdiParent = MyForms.GetForm<ParentForm>();
            LoadData();
        }

        public void LoadData()
        {
            dgv.DataMember = "";
            dgv.DataSource = null;
            dgv.DataSource = new em_employee_manager().GetAll(); //populating dgv
            //formating for dgv
            dgv.Columns[3].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgv.Columns[4].DefaultCellStyle.Format = "dd/MM/yyyy";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData(); //here refreshing can be used for removing sorting and filtering
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            if (cbxSort.SelectedIndex < 0)
                MessageBox.Show("Select an attribute to sort by"); //validating of combobox
            else
            {
                //sorting choices
                ByAttribute selectedAttribute;
                if (cbxSort.SelectedIndex == 0)
                    selectedAttribute = ByAttribute.Name;
                else if (cbxSort.SelectedIndex == 1)
                    selectedAttribute = ByAttribute.StartDate;
                else
                    selectedAttribute = ByAttribute.DischargeDate;

                dgv.DataMember = "";
                dgv.DataSource = null;
                dgv.DataSource = new em_employee_manager().SortLinq(selectedAttribute);//caling sort function with specified method of sorting
            }

        }
        private void btnFilter_Click(object sender, EventArgs e)
        {
            if (cbxFilter.SelectedIndex < 0)
            {
                MessageBox.Show("Select an attribute to filter");
            }
            else
            {
                ByAttribute attribute;
                if(cbxFilter.SelectedIndex == 0)
                {
                    attribute = ByAttribute.IsActive;
                }
                else if(cbxFilter.SelectedIndex == 1)
                {
                    attribute = ByAttribute.IsNotActive;
                }
                else
                {
                    attribute = ByAttribute.BothActive;
                }
                dgv.DataMember = "";
                dgv.DataSource = null;
                dgv.DataSource = new em_employee_manager().Filtering(attribute);
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new EmployeeEditForm();
            form.CreateNewEmployee(); //calling another form for adding new employee
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
                MessageBox.Show("Please select an item");
            else
            {
                var c = (em_employee)dgv.SelectedRows[0].DataBoundItem;
                new EmployeeEditForm().UpdateEmployee(c); //calling another form, where form mode is Update
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count == 0)
                MessageBox.Show("Please select a course");
            else
            {
                var c = (em_employee)dgv.SelectedRows[0].DataBoundItem;
                var SwipeCheck = new sp_swipe_manager().GetByEmployeeId(c.Id); //need data from sp_swipe for validation
                if (SwipeCheck == null) // if swipecheck is null that means there are no swipes for specific employee and we can delete the employee
                {
                    new em_employee_manager().Delete(c.Id);
                    LoadData();
                }
                else
                {
                    MessageBox.Show("You can not Delete an employee with Swipes");
                }
            }
        }
    }
}
