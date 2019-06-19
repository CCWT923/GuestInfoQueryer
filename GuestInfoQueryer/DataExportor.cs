using OfficeOpenXml;
using System.Data;
using System.IO;
using System.Text;

namespace GuestInfoQueryer
{
    /// <summary>
    /// 导出 Excel 文件的类
    /// </summary>
    class DataExportor
    {
        private string _FilePath = null;
        private DataTable _DataTableToExport = null;

        public DataExportor(string FilePath)
        {
            _FilePath = FilePath;
        }
        public DataExportor()
        {

        }

        private  string EncodingString(string s, string codePageTo, string codePageFrom)
        {
            string result;
            result = Encoding.GetEncoding(codePageTo).GetString(Encoding.GetEncoding(codePageFrom).GetBytes(s));
            return result;
        }

        /// <summary>
        /// 获取或设置文件的路径
        /// </summary>
        public string FilePath
        {
            get
            {
                return _FilePath;
            }
            set
            {
                _FilePath = value;
            }
        }
        /// <summary>
        /// 设置用于导出的数据
        /// </summary>
        public DataTable Data
        {
            set
            {
                _DataTableToExport = value;
            }
        }
        /// <summary>
        /// 要导出的文件类型
        /// </summary>
        public enum FileType
        {
            Excel,
            Text,
            HTML,
            CSV
        };

        /// <summary>
        /// 导出数据
        /// </summary>
        public void Export(FileType ExportFileType)
        {

            if(ExportFileType == FileType.Excel)
            {
                FileInfo fileInfo = new FileInfo(_FilePath);
                ExcelPackage excel = new ExcelPackage(fileInfo);
                ExcelWorksheet worksheet = excel.Workbook.Worksheets.Add("DataExport");
                for(int t = 0; t < _DataTableToExport.Columns.Count;t++)
                {
                    worksheet.Cells[1, t + 1].Value = EncodingString(_DataTableToExport.Columns[t].ColumnName,Encoding.Default.HeaderName,"cp850");
                }
                int row = 2;
                for(int i = 0; i < _DataTableToExport.Rows.Count; i++)
                {
                    for(int j = 0; j < _DataTableToExport.Columns.Count; j++)
                    {
                        worksheet.Cells[row, j + 1].Value = EncodingString(_DataTableToExport.Rows[i][j].ToString(), Encoding.Default.HeaderName, "cp850");
                    }
                    row++;
                }
                excel.Save();
            }
            else if(ExportFileType == FileType.Text)
            {

                FileStream stream = new FileStream(_FilePath, FileMode.CreateNew);
                StreamWriter writer = new StreamWriter(stream, Encoding.UTF8);
                for(int i = 0; i < _DataTableToExport.Columns.Count;i++)
                {
                    writer.Write(EncodingString(_DataTableToExport.Columns[i].ColumnName,Encoding.Default.HeaderName, "cp850") + '\t');
                }
                writer.WriteLine();
                for(int i = 0; i < _DataTableToExport.Rows.Count;i++)
                {
                    for(int j = 0; j < _DataTableToExport.Columns.Count;j++)
                    {
                        writer.Write(EncodingString(_DataTableToExport.Rows[i][j].ToString(),Encoding.Default.HeaderName, "cp850") + '\t');
                    }
                    writer.WriteLine();
                }
                stream.Flush();
                writer.Close();

                stream.Close();
            }
            else if(ExportFileType == FileType.HTML)
            {
                FileStream stream = new FileStream(_FilePath, FileMode.CreateNew);
                StreamWriter writer = new StreamWriter(stream, Encoding.UTF8);
                writer.WriteLine("<HTML><head><title>数据导出</title></head><body><table><tr>");
                for (int i = 0; i < _DataTableToExport.Columns.Count; i++)
                {
                    writer.Write("<th>" + EncodingString(_DataTableToExport.Columns[i].ColumnName, Encoding.Default.HeaderName, "cp850") + "</th>");
                }
                writer.Write("</tr>\n");
                for (int i = 0; i < _DataTableToExport.Rows.Count; i++)
                {
                    writer.Write("<tr>");
                    for (int j = 0; j < _DataTableToExport.Columns.Count; j++)
                    {
                        writer.Write("<td>" + EncodingString(_DataTableToExport.Rows[i][j].ToString(), Encoding.Default.HeaderName, "cp850") + "</td>");
                    }
                    writer.Write("</tr>");
                }
                writer.Write("</table></body></html>");
                stream.Flush();
                writer.Close();

                stream.Close();
            }
            else if(ExportFileType == FileType.CSV)
            {
                FileStream stream = new FileStream(_FilePath, FileMode.CreateNew);
                StreamWriter writer = new StreamWriter(stream, Encoding.UTF8);
                for (int i = 0; i < _DataTableToExport.Columns.Count; i++)
                {
                    writer.Write(EncodingString(_DataTableToExport.Columns[i].ColumnName, Encoding.Default.HeaderName, "cp850") + ',');
                }
                writer.WriteLine();
                for (int i = 0; i < _DataTableToExport.Rows.Count; i++)
                {
                    for (int j = 0; j < _DataTableToExport.Columns.Count; j++)
                    {
                        writer.Write(EncodingString(_DataTableToExport.Rows[i][j].ToString(), Encoding.Default.HeaderName, "cp850") + ',');
                    }
                    writer.WriteLine();
                }
                stream.Flush();
                writer.Close();

                stream.Close();
            }
        }

    }
}
