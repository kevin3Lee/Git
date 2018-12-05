using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectHelper.Class;

namespace ProjectHelper
{
    public partial class frmProject : Form
    {
        public frmProject()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView5_GQJ_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DGVAddRow dgvAddRow = new DGVAddRow();
            
            dgvAddRow.DataGridViewRemoveRow(dataGridView5_GQJ,sender,e);
        }

        private void button52_Click(object sender, EventArgs e)
        {
            DGVAddRow dgvAddRow = new DGVAddRow();
            dgvAddRow.AddDGVRow(dataGridView5_GQJ);
        }
    }
}
