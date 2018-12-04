using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aspose.Words;
using Aspose.Words.Tables;
using WHC.OrderWater.Commons;

namespace whc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertTable istTable = new InsertTable();
            istTable.ProcessTable("demo.doc","demowhc.doc");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“riskDBDataSet.info”中。您可以根据需要移动或删除它。
            this.infoTableAdapter.Fill(this.riskDBDataSet.info);

        }
        //
        private void button2_Click(object sender, EventArgs e)
        {
            DgvToTable dtt = new DgvToTable();
            dtt.ConvertDgvToDataTable(dataGridView1);
        }
    //
    

        
    }
}
