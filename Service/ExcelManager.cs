using OfficeOpenXml;
using System;
using System.IO;

namespace ProzzoroTest.Service
{
    public static class ExcelManager
    {
        public static void GenerateExcel()
        {
            var package = new ExcelPackage(Config.ExcelPath);
            var sheet = package.Workbook.Worksheets.Add("Main");

            // First row as topics
            string[] topics = new string[]
            {
                "FullName", "Age", "Experience", "Email", "PhoneNumber", "Message"
            };

            // Adding topic columns to file
            for (int i = 0; i < topics.Length; i++)
            {
                sheet.Cells[1, i + 1].Value = topics[i];
            }

            // Adding border to topics
            sheet.Cells[1, 1, 1, topics.Length].Style.Border.BorderAround(OfficeOpenXml.Style.ExcelBorderStyle.Thick);

            package.SaveAs(Config.ExcelPath);
        }
        public static void AppendToExcel(Models.ContactModel model)
        {
            if (!File.Exists(Config.ExcelPath))
            {
                GenerateExcel();
            }

            var package = new ExcelPackage(Config.ExcelPath);
            var sheet = package.Workbook.Worksheets[0];

            // Last empty row to write model data
            int row = sheet.Dimension.Rows + 1;
         
            // Writing by range
            sheet.Cells[row, 1, row, 6].LoadFromArrays(
                new object[][] {
                    new object[] {
                        model.FullName,
                        model.Age,
                        model.Experience,
                        model.Email,
                        model.PhoneNumber,
                        model.Message 
                    }
                });

            package.SaveAs(Config.ExcelPath);
        }

    }
}
