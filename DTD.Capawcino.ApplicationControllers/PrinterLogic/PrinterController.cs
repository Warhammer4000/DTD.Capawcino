using System.Drawing;
using System.Drawing.Printing;
using System.Text;
using DTD.Capawcino.Entities;

namespace DTD.Capawcino.ApplicationControllers.PrinterLogic
{
    public class PrinterController
    {
        private Bill Bill { get; set; }

        public void PrintReceiptForTransaction(Bill bill)
        {
            Bill = bill;
            PrintDocument recordDoc = new PrintDocument {DocumentName = "Receipt"};

            recordDoc.PrintPage += PrintReceiptPage; // function below
            recordDoc.PrintController = new StandardPrintController(); // hides status dialog popup
            // Comment if debugging 
            PrinterSettings ps = new PrinterSettings();
            ps.PrinterName = "EPSON TM-T20II Receipt";
            recordDoc.PrinterSettings = ps;
            
            recordDoc.Print();
            // --------------------------------------

            // Uncomment if debugging - shows dialog instead
            //PrintPreviewDialog printPrvDlg = new PrintPreviewDialog();
            //printPrvDlg.Document = recordDoc;
            //printPrvDlg.Width = 1200;
            //printPrvDlg.Height = 800;
            //printPrvDlg.ShowDialog();
            // --------------------------------------

            recordDoc.Dispose();
        }

        private void PrintReceiptPage(object sender, PrintPageEventArgs e)
        {
            float x = 10;
            float y = 5;
            float width = 270.0F; // max width I found through trial and error
            float height = 0F;

            Font drawFontArial12Bold = new Font("Arial", 12, FontStyle.Bold);
            Font drawFontArial10Regular = new Font("Arial", 10, FontStyle.Regular);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            // Set format of string.
            StringFormat drawFormatCenter = new StringFormat {Alignment = StringAlignment.Center};
            StringFormat drawFormatLeft = new StringFormat {Alignment = StringAlignment.Near};
            StringFormat drawFormatRight = new StringFormat {Alignment = StringAlignment.Far};

            // Draw string to screen.
            string text = Bill.DateTime.ToLongDateString();
            e.Graphics.DrawString(text, drawFontArial12Bold, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
            y += e.Graphics.MeasureString(text, drawFontArial12Bold).Height;

            text = "Company Name";
            e.Graphics.DrawString(text, drawFontArial12Bold, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
            y += e.Graphics.MeasureString(text, drawFontArial12Bold).Height;


            text = "Address";
            e.Graphics.DrawString(text, drawFontArial10Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatCenter);
            y += e.Graphics.MeasureString(text, drawFontArial12Bold).Height;

            foreach (var salesItem in Bill.SalesItem)
            {
                text = new StringBuilder().Append(salesItem.Name).Append(salesItem.Quantity).Append(salesItem.TotalPrice).ToString();
                e.Graphics.DrawString(text, drawFontArial10Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatLeft);
                y += e.Graphics.MeasureString(text, drawFontArial10Regular).Height;
            }

            text = new StringBuilder().Append("Total").Append(Bill.GrandTotal).ToString();
            e.Graphics.DrawString(text, drawFontArial10Regular, drawBrush, new RectangleF(x, y, width, height), drawFormatRight);
            y += e.Graphics.MeasureString(text, drawFontArial12Bold).Height;

            
            // ... and so on
        }
    }
}
