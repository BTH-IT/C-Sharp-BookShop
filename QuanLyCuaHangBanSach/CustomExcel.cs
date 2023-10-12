using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows;
using ExcelDataReader;
using Guna.UI.WinForms;
using Microsoft.Win32;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace QuanLyCuaHangBanSach
{
    public class CustomExcel
    {
        private static CustomExcel instance;

        public static CustomExcel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CustomExcel();
                }

                return CustomExcel.instance;
            }
            private set { CustomExcel.instance = value; }
        }
        public CustomExcel() { }

        public void ExportFileDatagridView(DataTable dataTable, string sheetName, int startPosition, string title, string[] headerList, int imgCol = -1)
        {
            string filePath = "";
            // tạo SaveFileDialog để lưu file excel
            SaveFileDialog dialog = new SaveFileDialog();

            // chỉ lọc ra các file có định dạng Excel
            dialog.Filter = "Excel | *.xlsx | Excel 2003 | *.xls";

            // Nếu mở file và chọn nơi lưu file thành công sẽ lưu đường dẫn lại dùng
            if (dialog.ShowDialog() == true)
            {
                filePath = dialog.FileName;
            }

            // nếu đường dẫn null hoặc rỗng thì báo không hợp lệ và return hàm
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Đường dẫn báo cáo không hợp lệ");
                return;
            }

            try
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                using (ExcelPackage p = new ExcelPackage())
                {
                    // đặt tên người tạo file
                    p.Workbook.Properties.Author = "BTH";

                    // đặt tiêu đề cho file
                    p.Workbook.Properties.Title = title;

                    //Tạo một sheet để làm việc trên đó
                    p.Workbook.Worksheets.Add(sheetName);

                    // lấy sheet vừa add ra để thao tác
                    ExcelWorksheet ws = p.Workbook.Worksheets[0];

                    // đặt tên cho sheet
                    ws.Name = sheetName;
                    // fontsize mặc định cho cả sheet
                    ws.Cells.Style.Font.Size = 11;
                    // font family mặc định cho cả sheet
                    ws.Cells.Style.Font.Name = "Calibri";

                    // lấy ra số lượng cột cần dùng dựa vào số lượng header
                    var countColHeader = headerList.Count();
                    // merge các column lại từ column 1 đến số column header
                    // gán giá trị cho cell vừa merge là Thống kê thông tni User Kteam
                    ws.Cells[1, 1].Value = title;
                    ws.Cells[1, 1, 1, countColHeader].Merge = true;
                    // in đậm
                    ws.Cells[1, 1, 1, countColHeader].Style.Font.Bold = true;
                    // căn giữa
                    ws.Cells[1, 1, 1, countColHeader].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

                    int colIndex = 1;
                    int rowIndex = 2;

                    //tạo các header từ column header đã tạo từ bên trên
                    foreach (var item in headerList)
                    {
                        var cell = ws.Cells[rowIndex, colIndex];

                        //set màu thành gray
                        var fill = cell.Style.Fill;
                        fill.PatternType = ExcelFillStyle.Solid;
                        fill.BackgroundColor.SetColor(System.Drawing.Color.LightBlue);

                        //căn chỉnh các border
                        var border = cell.Style.Border;
                        border.Bottom.Style =
                            border.Top.Style =
                            border.Left.Style =
                            border.Right.Style = ExcelBorderStyle.Thin;

                        //gán giá trị
                        cell.Value = item;

                        colIndex++;
                    }

                    rowIndex++;

                    for (int row = 0; row < dataTable.Rows.Count; row++)
                    {
                        DataRow dataRow = dataTable.Rows[row];
                        colIndex = 0;
                        for (int col = startPosition; col < dataTable.Columns.Count; col++)
                        {

                            if (col == imgCol) continue;

                            ws.Cells[rowIndex, ++colIndex].Value = dataRow[col]; 
                       }
                        rowIndex++;
                    }

                    //Lưu file lại
                    Byte[] bin = p.GetAsByteArray();
                    File.WriteAllBytes(filePath, bin);
                }

                MessageBox.Show("Tạo Excel thành công");
            } catch (Exception ex)
            {
                MessageBox.Show("Tạo Excel thất bại:" + ex.Message);
            }
        }

        public DataTable ConvertListToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                Console.WriteLine(prop.Name);
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
        
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }


        public DataTable ConvertDataGridViewToDataTable(GunaDataGridView dgv)
        {
            DataTable ExportDataTable = new DataTable();
            foreach (System.Windows.Forms.DataGridViewColumn col in dgv.Columns)
            {
                ExportDataTable.Columns.Add(col.Name);
            }
            foreach (System.Windows.Forms.DataGridViewRow row in dgv.Rows)
            {
                DataRow dRow = ExportDataTable.NewRow();
                foreach (System.Windows.Forms.DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                ExportDataTable.Rows.Add(dRow);
            }
            return ExportDataTable;
        }

        public DataTable ImportFile()
        {
            OpenFileDialog fil = new OpenFileDialog();
            fil.ShowDialog();

            string path = fil.FileName.ToString();

            if (path == string.Empty) return null;

            var stream = File.Open(path, FileMode.Open, FileAccess.Read);

            var reader = ExcelReaderFactory.CreateReader(stream);

            var result = reader.AsDataSet();

            var tables = result.Tables.Cast<DataTable>();

            return tables.ElementAt(0);
        }
    }
}
