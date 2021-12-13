using Microsoft.Office.Interop.Excel;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace dekatreís_octavo.Bus
{
    public class ExcelHelper
    {
        public static ExcelPackage CreateExcelFileByHour(List<BaoCaoMatDoTheoGio> list)
        {
            var excelPackage = new ExcelPackage();
            
            // Tạo author cho file Excel
            excelPackage.Workbook.Properties.Author = "Yami";
            // Tạo title cho file Excel
            excelPackage.Workbook.Properties.Title = "Test Report";
            // thêm tí comments vào làm màu 
            //excelPackage.Workbook.Properties.Comments = "This is my fucking generated Comments";
            // Add Sheet vào file Excel
            excelPackage.Workbook.Worksheets.Add("First Sheet");
            // Lấy Sheet bạn vừa mới tạo ra để thao tác 
            var workSheet = excelPackage.Workbook.Worksheets[0];
            // Đổ data vào Excel file
            workSheet.Cells[1, 1].LoadFromCollection(list, true, OfficeOpenXml.Table.TableStyles.Dark9);
            // BindingFormatForExcel(workSheet, list);
            excelPackage.Save();
            return excelPackage;
            
        }
        public static ExcelPackage CreateExcelFileByDay(List<BaoCaoMatDoTheoNgay> list)
        {
            var excelPackage = new ExcelPackage();
            
            // Tạo author cho file Excel
            excelPackage.Workbook.Properties.Author = "Yami";
            // Tạo title cho file Excel
            excelPackage.Workbook.Properties.Title = "Test Report";
            // thêm tí comments vào làm màu 
            //excelPackage.Workbook.Properties.Comments = "This is my fucking generated Comments";
            // Add Sheet vào file Excel
            excelPackage.Workbook.Worksheets.Add("Kteam sheet");
            // Lấy Sheet bạn vừa mới tạo ra để thao tác 
            //var workSheet = excelPackage.Workbook.Worksheets[0]; 
            ExcelWorksheet ws = excelPackage.Workbook.Worksheets[0];
            // Đổ data vào Excel file
            ws.Cells[1, 1].LoadFromCollection(list, true, OfficeOpenXml.Table.TableStyles.Dark9);

            ws.Columns.AutoFit();
            //BindingFormatForExcel(workSheet, list);
            excelPackage.Save();
            return excelPackage;
        }
        
    }

    public class BaoCaoMatDoTheoGio
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public int Hour { get; set; }
        public int XeVao { get; set; }
        public int XeRa { get; set; }
        //public int ChenhLech { get; set; }
    }
    public class BaoCaoMatDoTheoNgay
    {
        public int Id { get; set; }
        public string Date { get; set; }
        public int XeVao { get; set; }
        //public int ChenhLech { get; set; }
    }
}
