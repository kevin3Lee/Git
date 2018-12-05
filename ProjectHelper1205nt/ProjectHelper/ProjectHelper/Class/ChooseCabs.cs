using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectHelper
{
    /// <summary>
    /// 本类负责从传入的控件中处理屏柜选择
    /// </summary>
    class ChooseCabs
    {
        /// <summary>
        /// GetCabNum()函数用于从TableLayoutPanel控件中的CheckBox组获得单排屏柜，并返回一个List
        /// </summary>
        /// <param name="tblayoutPanel"></param>
        /// <returns></returns>
        private List<CheckBox> GetCabNum(TableLayoutPanel tblayoutPanel)
        {          
            //
            List<CheckBox> cabList = new List<CheckBox>();//新建一个数组存放所有的CheckBox
            //遍历表格控件区域内所有的CheckBox控件
            foreach (Control ctl in tblayoutPanel.Controls)
            {
                if (ctl is CheckBox cbx)
                {
                    cabList.Add(cbx);
                }
                //
            }
            return cabList;
        }

        /// <summary>
        /// ProcessCabText()函数接收一个CheckBox的List
        /// </summary>
        /// <param name="cabList"></param>
        /// <param name="txtBox"></param>
        private void ProcessCabText(List<CheckBox> cabList,TextBox txtBox)
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

            txtBox.Text = "在与" + cabNameText + "相邻的" + nextCabNameText + "上悬挂“运行设备”标识牌。";
        }
    }
}
