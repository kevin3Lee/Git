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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //
        private void button1_Click(object sender, EventArgs e)
        {
            ProcessSelectCheckBoxText();
            //ProcessUnselectCheckBoxText();

        }
        //
        private void ProcessSelectCheckBoxText()
        {
            //建立list_All，存放区域内所有CheckBox的text，元素个数等于CheckBox的数量

            ArrayList listSelectPG = new ArrayList(); //新建一个列表存放屏柜名称
            
            //CheckBox[] listCheckBoxs = new CheckBox[0];
            int selectPGListNum; //列表内屏柜数量

            string PGSelectText = ""; //初始化输出文本
            
            //遍历表格控件区域内所有的CheckBox控件
            foreach (Control ctl in this.tableLayoutPanel1.Controls)
            {
                if (ctl is CheckBox ckbox)//如果控件是MyCheckBox
                {
                    //如果选中，则将屏柜名称加入列表中
                    if (ckbox.Checked)
                    {
                        listSelectPG.Add(ckbox.Text);
                    }
                }
            }
            //
            selectPGListNum = listSelectPG.Count; //获得所选屏柜数量


            //
            //对选中屏柜名称的文本进行合成
            for (int i = 0; i < selectPGListNum; i++)
            {
                //show the last "," or NOT，如果是最后一个屏柜，其后不显示顿号
                string endNote = "";

                if (i < selectPGListNum - 1)
                    endNote = "、";
                else
                    endNote = "";

                //循环结束后，合成文本PGText
                PGSelectText = PGSelectText + listSelectPG[i].ToString() + endNote;
            }

            textBox1.Text = PGSelectText; //将合成文本填写到文本框中,作为工作地点
        }

        private void ProcessUnselectCheckBoxText()
        {
            ArrayList listCheckBox = new ArrayList();//存放CheckBox
            int checkBoxNum;
            //遍历表格控件区域内所有的CheckBox控件
            foreach (Control ctl in this.tableLayoutPanel1.Controls)
            {
                if (ctl is CheckBox ckbox)//如果控件是MyCheckBox
                {
                    listCheckBox.Add(ckbox);//则把MyCheckBox添加到listCheckBox中
                    checkBoxNum = listCheckBox.Count;//获取CheckBox的数量

                    //如果选中，则将屏柜名称加入列表中
                    if (ckbox.Checked)
                    {
                        //listSelectPG.Add(ckbox.Text);
                    }
                }
            }
            //活动总共屏柜数量
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.Show();
        }
    }
}
