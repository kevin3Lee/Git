using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lnote
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int itemNum = checkedListBox1.Items.Count;
            string proText = "";
            for (int i = 0; i < itemNum; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    if (i>0 && i < itemNum)
                    {
                        proText = checkedListBox1.Items[i].ToString();
                    }
                }
                proText = proText + "、" + checkedListBox1.Items[i];

            }

            textBox1.Text = proText;
        }
    }
}
