using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lnote
{
    class ClassCab
    {
        //
        //GetCabNum()函数用于获得单排屏柜，返回一个List
        private List<CheckBox> GetCabNum(Control tabLay)
        {
            
            //
            List<CheckBox> cabList = new List<CheckBox>();//新建一个数组存放所有的CheckBox
            //遍历表格控件区域内所有的CheckBox控件
            foreach (Control ctl in this.tableLayoutPanel1.Controls)
            {
                if (ctl is CheckBox cbx)
                {
                    cabList.Add(cbx);
                }
                //
            }
            return cabList;
        }

        //
        //ProcessCabText()函数接收一个CheckBox的List
        private void ProcessCabText(List<CheckBox> cabList)
        {
            string cabNameText = "";
            string nextCabNameText = "";
            //
            for (int i = 0; i < cabList.Count; i++) //从第一个屏柜到最后一个屏柜
            {
                if (i > 0 && i < cabList.Count-1) //如果该屏柜位置不在两边
                {
                    //如果该屏柜被选中，且左右两侧屏柜没有被选中
                    if (cabList[i].Checked == true && cabList[i-1].Checked == false) 
                    {
                        cabNameText = cabList[i].Text;
                        nextCabNameText = cabList[i-1].Text + "、" + cabList[i+1].Text;
                    }
                }
                else if (i == 0) //如果屏柜位置在最左边，其左侧不再有屏柜，只考虑右侧
                {
                    if (cabList[i].Checked == true && cabList[i+1].Checked == false)
                    {
                        cabNameText = cabList[i].Text;
                        nextCabNameText = cabList[i+1].Text;
                    }
                }
                else if (i == cabList.Count-1) //如果屏柜位置在最右边，其右侧不再有屏柜，只考虑左侧
                {
                    if (cabList[i].Checked == true && cabList[i-1].Checked == false)
                    {
                        cabNameText = cabList[i].Text;
                        nextCabNameText = cabList[i-1].Text;
                    }
                } 
            }

            textBox1.Text = "在与" + cabNameText + "相邻的" + nextCabNameText + "上悬挂“运行设备”标识牌。";
        }
    }
}
