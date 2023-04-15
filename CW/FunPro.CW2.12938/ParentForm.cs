using FunPro.CW2._12938.DAL;
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
    public partial class ParentForm : Form
    {
        public ParentForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void allEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //calling all_employees form by calling Myforms class
            MyForms.GetForm<all_employees>().Show();
        }

        private void addEditEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //EmployeeEditForm contains two different method of opening one form(for creating and updating)
            var form = new EmployeeEditForm();
            form.CreateNewEmployee(); //CreateNewEmployee() includes to iself sql command Create
        }

        private void allSwipesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyForms.GetForm<all_swipes_form>().Show();
        }

        private void addSwipeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new SwipesAddForm();
            form.CreateNewSwipe();
        }

        private void generateAReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MyForms.GetForm<EmployeeReportForm>().Show();
        }




        private void ParentForm_Load(object sender, EventArgs e)
        {
        }
        private void swapToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
    }
}
