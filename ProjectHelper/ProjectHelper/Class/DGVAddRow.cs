using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectHelper.Class
{
    /// <summary>
    /// 本类传入一个DataGridView以及事件参数sender和DataGridViewCellEventArgs,DataGridView调用实例可以显示序号，以及删除对应行
    /// </summary>
    class DGVAddRow
    {
        public void DataGridViewRemoveRow(DataGridView dgv,object sender, DataGridViewCellEventArgs e)
        {
            //
            DgvRemoveRow(dgv, e);
            //
            //DgvShowColumnNo(dgv);
        }

        /// <summary>
        /// 删除当前行
        /// </summary>
        /// <param name="dgv"></param>
        /// <param name="e"></param>
        private void DgvRemoveRow(DataGridView dgv, DataGridViewCellEventArgs e)
        {
            dgv.Columns[0].Frozen = true;
            if (e.RowIndex >= 0)
            {
                DataGridViewColumn column = dgv.Columns[e.ColumnIndex];
                if (column is DataGridViewButtonColumn)
                {
                    dgv.Rows.RemoveAt(e.RowIndex);
                    DgvShowColumnNo(dgv);//每删除一行后，刷新序号
                }         
            }
            //
            
            
        }

        /// <summary>
        /// 按钮在dgv最后添加一行
        /// </summary>
        /// <param name="dgv"></param>
        public void AddDGVRow(DataGridView dgv)
        {
            dgv.Rows.Add();
            DgvShowColumnNo(dgv);//刷新序号
        }

        /// <summary>
        /// 在第一列显示序号
        /// </summary>
        /// <param name="dgv"></param>
        private void DgvShowColumnNo(DataGridView dgv)
        {
            dgv.RowHeadersWidth = 50;
            for (int i = 0; i < dgv.RowCount; i++)
            {
                int j = i + 1;
                dgv.Rows[i].HeaderCell.Value = j.ToString();
            }
        }
    }
}
