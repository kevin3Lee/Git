using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Aspose.Words;
using Aspose.Words.Tables;
using WHC.OrderWater.Commons;
using log4net;

namespace whc
{
    class DgvToTable
    {
        ///<summary>
        ///输入一个DataGridView对象,并转换为DataTable对象,最终生成word文档并插入指定书签位置
        /// </summary>
        public void ConvertDgvToDataTable(DataGridView dgv)
        {
            try
            {
                string templateFile = Application.StartupPath + @"\demo.doc";//定义模板文件路径及名称
                string outputFileName = "demodgv.doc";//定义输出文件名称

                Aspose.Words.Document doc = new Aspose.Words.Document(templateFile);//利用模板文件生成一个doc文档
                Aspose.Words.DocumentBuilder builder = new Aspose.Words.DocumentBuilder(doc);//生成builder实例，以操作刚生成的doc文档
               
                var dt = ConvertDataGridViewIntoDataTable(dgv);

                var widthList = GetWidthList(dt, builder);

                ////
                builder.MoveToBookmark("table");//定位到书签”table“处

                WriteDataTableIntoDoc(dt, builder, widthList);
                doc.Range.Bookmarks["table"].Text = "";//表格写入完成后，清除table书签标识
                doc.Save(outputFileName);

                if (MessageUtil.ShowYesNoAndTips("保存成功，是否打开新生成的方案？") == System.Windows.Forms.DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(outputFileName);
                }
            }
            catch (Exception e)
            {
                LogHelper.Error(e);
                MessageUtil.ShowError(e.Message);
                return;
            }
        }

        /// <summary>
        /// 将DataGridView中的数据转换为DataTable以方便写入word
        /// </summary>
        /// <param name="dgv"></param>
        /// <returns></returns>
        private static DataTable ConvertDataGridViewIntoDataTable(DataGridView dgv)
        {
            DataTable dt = new DataTable(); //新建一个DateTable用于存放DataGridView数据

            //添加列名到dt
            foreach (DataGridViewColumn dgvColumn in dgv.Columns)
            {
                dt.Columns.Add(dgvColumn.Name); //
            }

            ////添加每个单元格内容，填充到dt
            foreach (DataGridViewRow dgvRow in dgv.Rows) //遍历DataGridView中的每一行
            {
                DataRow dataRow = dt.NewRow(); //为DataTable新建行
                foreach (DataGridViewCell dgvCell in dgvRow.Cells) //遍历DataGridView每行中的每个单元格
                {
                    dataRow[dgvCell.ColumnIndex] = dgvCell.Value; //依次将单元格内容填充给dt中新建Row的每一个Cell
                }

                dt.Rows.Add(dataRow); //填充完毕一行后，将该行内容再填充到dt中
            }

            return dt;
        }

        /// <summary>
        /// 开始将前面生成的表格利用for循环写入word文件
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="builder"></param>
        /// <param name="widthList"></param>
        private static void WriteDataTableIntoDoc(DataTable dt, DocumentBuilder builder, List<double> widthList)
        {
            
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                for (int j = 0; j < dt.Columns.Count; j++) //注意
                {
                    builder.InsertCell(); //插入单元格
                    builder.CellFormat.Borders.LineStyle = LineStyle.Single; //边框线型
                    builder.CellFormat.Borders.Color = Color.Black; //边框颜色
                    builder.CellFormat.Width = widthList[j]; //列宽度
                    builder.CellFormat.VerticalMerge = Aspose.Words.Tables.CellMerge.None; //？
                    builder.CellFormat.VerticalAlignment = CellVerticalAlignment.Center; //单元格文字垂直居中
                    builder.ParagraphFormat.Alignment = ParagraphAlignment.Center; //单元格文字水平居中对齐
                    builder.Write(dt.Rows[i][j].ToString()); //将内容最终填入i行j列的单元格内
                }

                builder.EndRow(); //填充完第各列后，结束第i行写入
            }
        }

        /// <summary>
        /// 跟踪调整对应各列宽度
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="builder"></param>
        /// <returns></returns>
        private static List<double> GetWidthList(DataTable dt, DocumentBuilder builder)
        {       
            List<double> widthList = new List<double>(); //建立一个List，存放各列单元格的宽度

            for (int i = 0; i < dt.Columns.Count; i++) //获取列数
            {
                builder.MoveToCell(0, 0, i, 0); //移动对应列单元格
                double cellWidth = builder.CellFormat.Width; //获取单元格宽度
                widthList.Add(cellWidth);
            }
            return widthList;
        }

        
    }
}
