using System;
using System.Collections;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //
        private void Button1_Click(object sender, EventArgs e)
        {
            List<CheckBox> myList = GetCabNum();//调用GetCabNum()方法获得单排屏柜列表
            ProcessCabText(myList);//调用ProcessCabText()方法，
        }

        
        //
        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); //清空文本框
            textBox2.Clear(); //清空文本框
            textBox3.Clear(); //清空文本框
        }
    }
}
