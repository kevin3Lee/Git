using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectHelper.Forms;

namespace ProjectHelper.Forms
{
    public partial class frm_Main : Form
    {
        public frm_Main()
        {
            InitializeComponent();
        }

        private void Btn_EditProject_Click(object sender, EventArgs e)
        {
            frmProject frm_project = new frmProject();
            frm_project.Show();
            frm_Main frm_main = new frm_Main();
            frm_main.Hide();


        }
    }
}
