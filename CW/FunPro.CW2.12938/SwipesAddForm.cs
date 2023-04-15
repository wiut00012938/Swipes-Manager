using FunPro.CW2._12938.DAL;
using FunPro.CW2.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FunPro.CW2._12938
{
    public partial class SwipesAddForm : Form
    {
        public SwipesAddForm()
        {
            InitializeComponent();
        }
        public sp_swipe sp_swipe { get; set; }

        public void CreateNewSwipe()
        {
            sp_swipe = new sp_swipe();
            InitializeControls();
            MdiParent = MyForms.GetForm<ParentForm>();
            Show();
        }
        private void InitializeControls()
        {
            cbxEmployeeName.DataSource = new em_employee_manager().GetAll(); //inititialzing representation data for combobox
        }
        //As for employeeAdd, we need to match user data with class properties
        
        private void ShowSwipeInControls()
        {
            cbxEmployeeName.SelectedValue = sp_swipe.EmployeeId.Id;
            dtpSwipeDate.Value = sp_swipe.Date;
            dtpSwipeIn.Value = sp_swipe.In;
            dtpSwipeOut.Value = sp_swipe.Out;
        }

        private void GrabUserInput()
        {
            sp_swipe.EmployeeId = (em_employee)cbxEmployeeName.SelectedItem;
            sp_swipe.Date = dtpSwipeDate.Value;
            sp_swipe.In = dtpSwipeIn.Value;
            sp_swipe.Out = dtpSwipeOut.Value;
        }
        

        private void btnSave_Click(object sender, EventArgs e)
        {
            //btnSave event include to itself many validation for not allowing a user to mess swipes and break a logic
            var EmployeeInfo = new em_employee_manager().GetById(Convert.ToInt32(cbxEmployeeName.SelectedValue)); //we need to check employee information for selected employee
            var SwipeEmployeeInfo = new sp_swipe_manager().GetSwipeDates(Convert.ToInt32(cbxEmployeeName.SelectedValue),
                Convert.ToDateTime(dtpSwipeDate.Value.ToString("dd.MM.yyyy 00:00")).Ticks, Convert.ToDateTime(dtpSwipeDate.Value.ToString("dd.MM.yyyy 23:59")).Ticks); // it is obvious that such kind of method of selecting swipe with specific employeeid and date range is not optimized. But because of ticks property for storing our dates, wee need to comparee a range of one day  

            if (cbxEmployeeName.SelectedIndex < 0)
            {
                MessageBox.Show("Select an employee name for adding a swipe"); //value from combo box must be selected
            }
            else if (SwipeEmployeeInfo != null)
            {
                MessageBox.Show("There is a swipe for selected date for specific employee");//GetSwipeDates() was specifically created for this validation. If from sql queary null is returned, which means there is no such id and date in a database that was entered by a user, we are fine
            }
            else if(EmployeeInfo.IsActive == false)
            {
                MessageBox.Show("Swipes for employees who are not active is not allowed");
            }
            else if (EmployeeInfo.StartDate > dtpSwipeDate.Value) //working with dates comparing
            {
                MessageBox.Show("Swipes for employees whose start date are later than entered swipe date are not allowed");
            }
            else if (EmployeeInfo.DischargeDate < dtpSwipeDate.Value)
            {
                MessageBox.Show("Swipes for employees whose discharge date is earlier than swipe date are not allowed");
            }
            else
            {
                try
                {
                    GrabUserInput();
                    var manager = new sp_swipe_manager();
                    manager.Create(sp_swipe);

                    MyForms.GetForm<all_swipes_form>().LoadData();
                    Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SwipesAddForm_Load(object sender, EventArgs e)
        {

        }

    }
}
