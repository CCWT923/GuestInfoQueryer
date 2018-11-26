using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OfficeOpenXml;
using System.Data;
using System.IO;

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
        public void Export(int StartRow, int RowsCount, FileType ExportFileType)
        {
            if(_DataTableToExport == null)
            {
                throw new Exception("数据表未初始化！");
            }

            if(_FilePath == null)
            {
                throw new Exception("未指定文件路径！");
            }
            if(StartRow > RowsCount)
            {
                throw new Exception("指定的数据范围不合法！");
            }

            if(ExportFileType == FileType.Excel)
            {
                FileInfo fileInfo = new FileInfo(_FilePath);
                ExcelPackage excel = new ExcelPackage(fileInfo);

            }
            else if(ExportFileType == FileType.Text)
            {

            }
            else if(ExportFileType == FileType.HTML)
            {

            }

        }

    }
}
