using Syncfusion.Pdf;
using Syncfusion.Pdf.Tables;
using System.Data;
using System.Drawing;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace PdfTableSample
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new PDF document.
            PdfDocument doc = new PdfDocument();

            //Add a page.

            PdfPage page = doc.Pages.Add();

            // Create a PdfLightTable.

            PdfLightTable pdfLightTable = new PdfLightTable();

            // Initialize DataTable to assign as DateSource to the light table.

            DataTable table = new DataTable();

            //Include columns to the DataTable.

            table.Columns.Add("Name");

            table.Columns.Add("Age");

            table.Columns.Add("Sex");

            //Include rows to the DataTable.

            table.Rows.Add(new string[] { "abc", "21", "Male" });

            //Assign data source.

            pdfLightTable.DataSource = table;

            //Draw PdfLightTable.

            pdfLightTable.Draw(page, new PointF(0, 0));

            //Save the document.

            doc.Save("PdfTable.pdf");

            //Close the document

            doc.Close(true);

            //This will open the PDF file so, the result will be seen in default PDF viewer
            Process.Start("PdfTable.pdf");
        }
    }
}
