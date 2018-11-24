using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OfficeOpenXml;
using System.Data;

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
        /// 导出数据
        /// </summary>
        public void Export(int StartRow, int RowsCount)
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

        }

    }
}
