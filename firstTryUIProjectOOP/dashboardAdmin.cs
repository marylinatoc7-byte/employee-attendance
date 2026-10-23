using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstTryUIProjectOOP
{
    public partial class dashboardAdmin : Form
    {
        public dashboardAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnNotif_Click(object sender, EventArgs e)
        {

        }

        private void lblActiveEmp_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            dashboardEmployee dash = new dashboardEmployee();
            dash.Show();

            this.Hide();
        }

        private void btnEmpManage_Click(object sender, EventArgs e)
        {
            EmployeeListForm employeeListForm = new EmployeeListForm();
            employeeListForm.Show();
            this.Hide();
        }
    }
}
