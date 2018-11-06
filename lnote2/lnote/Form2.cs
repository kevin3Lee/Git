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
        private void button1_Click(object sender, EventArgs e)
        {
            string outputText1 = "";
            string outputText2 = "";

            List<CheckBox> myList = new List<CheckBox>();//新建一个数组存放所有的CheckBox
            //
            //遍历表格控件区域内所有的CheckBox控件
            foreach (Control ctl in this.tableLayoutPanel1.Controls)
            {
                if (ctl is CheckBox cbx)
                {
                    myList.Add(cbx);
                }
                //
            }
            //
            for (int i = 0; i < myList.Count; i++) //从第一个屏柜到最后一个屏柜
            {
                if (i > 0 && i < myList.Count) //如果该屏柜位置不在两边
                {
                    if (myList[i].Checked == true && myList[i-1].Checked == false) //如果该屏柜被选中，且左侧屏柜没有被选中
                    {
                        outputText1 = myList[i].Text;
                        outputText2 = myList[i-1].Text;
                    }
                }
                else if (i == 0) //如果屏柜位置在最左边，其左侧不再有屏柜，只考虑右侧
                {

                }
                else if (i == myList.Count) //如果屏柜位置在最右边，其右侧不再有屏柜，只考虑左侧
                {

                }
                
            }

            textBox1.Text = "在与" + outputText1 + "相邻的" + outputText2 + "上悬挂“运行设备”标识牌。";

        }
        //
        //通过遍历得到CheckBox控件数量
        private int GetPGCount()
        {
            List<CheckBox> listCheckBox = new List<CheckBox>();//新建一个列表存放CheckBox

            //遍历表格控件区域内所有的CheckBox控件
            foreach (Control ctl in this.tableLayoutPanel1.Controls)
            {
                if (ctl is CheckBox cbx)
                {
                    listCheckBox.Add(cbx);
                    //CheckBox checkBoxItem = (CheckBox) ctl;
                    //checkBoxItem.Text = listCheckBox[index++].ToString();//关键一步！
                    //CheckBox item2 = (CheckBox) listCheckBox[index];
                }
            }

             return listCheckBox.Count;
        }
        //itemCount 为屏柜数量
        //private string ProcessUnCheckBox()
        //{  
            
            //
            //return outputText;

            //allPGlistNum = listAllPG.Count; //获得列表元素数量

            ////对选中的文本进行合成
            //for (int i = 0; i < allPGlistNum; i++)
            //{
            //    //show the last "," or NOT，如果是最后一个屏柜，其后不显示顿号
            //    string endNote = "";

            //    if (i < allPGlistNum - 1)
            //        endNote = "、";
            //    else
            //        endNote = "";

            //    //循环结束后，合成文本PGText
            //    unPGText = unPGText + listAllPG[i].ToString() + endNote;
            //}

            //textBox1.Text = unPGText; //将合成文本填写到文本框中
            //textBox2.Text = "在" + unPGText + "上悬挂“在此工作”标识牌。";
            //textBox3.Text = "在与" + listAllPG[0].ToString() + "相邻的" + checkBox1.Text + "上悬挂“运行设备”标识牌。";
        //}
        //
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); //清空文本框
            textBox2.Clear(); //清空文本框
            textBox3.Clear(); //清空文本框
        }
    }
}
