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
    class InsertTable
    {
        public void ProcessTable(string tmpFileName, string outputFileName)
        {
            try
            {
                string templateFile = Application.StartupPath + @"\" + tmpFileName;
                //string outputFileName = "demowhc.doc";
                Aspose.Words.Document doc = new Aspose.Words.Document(templateFile);
                Aspose.Words.DocumentBuilder builder = new Aspose.Words.DocumentBuilder(doc);
                //
                DataTable nameList = DataTableHelper.CreateTable("编号,姓名,时间");//新建一个名为nameList的表格，以"编号,姓名,时间"作为表头
                DataRow row = null;//新建一行用row标识，并初始化为null
                                   //用for循环生成表格
                for (int i = 0; i < 50; i++)
                {
                    row = nameList.NewRow();//生成表格的新行
                    row["编号"] = i.ToString().PadLeft(4, '0');//填充”编号“列对应的该行单元格，并调整宽度和对齐控制
                    row["姓名"] = "填充" + i.ToString();//填充”姓名“列对应的该行单元格
                    row["时间"] = DateTime.Now.ToString();//填充”时间“列对应的该行单元格
                    nameList.Rows.Add(row);//完成填充后，将该行并入nameList表格中作为表格的一行
                }
                //调整对应各列宽度
                //建立一个List，存放各列单元格的宽度
                List<double> widthList = new List<double>();
                for (int i = 0; i < nameList.Columns.Count; i++)//获取列数
                {
                    builder.MoveToCell(0, 0, i, 0);//移动对应列单元格
                    double cellWidth = builder.CellFormat.Width;//获取单元格宽度
                    widthList.Add(cellWidth);
                }
                //
                builder.MoveToBookmark("table");//定位到书签”table“处

                //开始将前面生成的表格利用for循环写入word文件
                for (int i = 0; i < nameList.Rows.Count; i++)
                {
                    for (int j = 0; j < nameList.Columns.Count; j++)
                    {
                        builder.InsertCell();//插入单元格
                        builder.CellFormat.Borders.LineStyle = LineStyle.Single;//边框线型
                        builder.CellFormat.Borders.Color = Color.Black;//边框颜色
                        builder.CellFormat.Width = widthList[j];//列宽度
                        builder.CellFormat.VerticalMerge = Aspose.Words.Tables.CellMerge.None;//？
                        builder.CellFormat.VerticalAlignment = CellVerticalAlignment.Center;//单元格文字垂直居中
                        builder.ParagraphFormat.Alignment = ParagraphAlignment.Center;//单元格文字水平居中对齐
                        builder.Write(nameList.Rows[i][j].ToString());//将内容最终填入i行j列的单元格内
                    }
                    builder.EndRow();//填充完第各列后，结束第i行写入
                }

                doc.Range.Bookmarks["table"].Text = "";//表格写入完成后，清除table书签标识
                                                       //
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
    }
}
