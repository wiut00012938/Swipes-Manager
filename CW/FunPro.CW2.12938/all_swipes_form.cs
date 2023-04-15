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
    public partial class all_swipes_form : Form
    {
        public all_swipes_form()
        {
            InitializeComponent();
        }

        private void all_swipes_form_Load(object sender, EventArgs e)
        {
            MdiParent = MyForms.GetForm<ParentForm>();//making a form be inside a parent form
            LoadData();
        }

        public void LoadData()
        {
            dgv.DataMember = "";
            dgv.DataSource = null;
            dgv.DataSource = new sp_swipe_manager().GetAll(); // populating dgv by calling swipe manager
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new SwipesAddForm();
            form.CreateNewSwipe(); //calling another form for adding a new swipe
        }
    }
}
