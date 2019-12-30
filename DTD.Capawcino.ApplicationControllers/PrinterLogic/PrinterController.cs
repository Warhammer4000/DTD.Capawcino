using System.Drawing;
using System.Drawing.Printing;

using System.Windows.Forms;
using DTD.Capawcino.Entities;


namespace DTD.Capawcino.ApplicationControllers.PrinterLogic
{
    public class PrinterController
    {
        private Bill Bill { get; set; }
        private string LogoPath { get; set; }
        private string CompanyName { get; set; }
        private string CompanyLocation { get; set; }
        private string CompanyContactInfo { get; set; }





        public void PrintReceiptForTransaction(Bill bill)
        {
            Bill = bill;
   
            CompanyName = "Capawcino Cat Cafe";
            CompanyLocation = @"Capawcino Cat Cafe, House: C52, Block: C, Road: W1, Eastern Housing Pallabi, Dhaka 1216";
            CompanyContactInfo = "01912995783";
            LogoPath = @"C:\Users\BS_269\Downloads\cropped-bs-logo-1.png";
            PrintReceipt();

   
        }

       

     

        private void PrintReceipt()
        {
            PrintDialog printDialog=new PrintDialog();
            PrintDocument printDocument=new PrintDocument();

            printDialog.Document = printDocument;
            printDocument.PrintPage += PrintDocument_PrintPage;
            DialogResult result = printDialog.ShowDialog();
            if (result==DialogResult.OK)
            {
                printDocument.Print();
            }

        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphic = e.Graphics;

            Font font=new Font("Courier New",12);
            float fontHeight = font.GetHeight();
            int startX = 10;
            int startY = 10;
            int offSet = 40;

            var icon = Image.FromFile(LogoPath);
            graphic.DrawImage(icon,new Point(startX,startY+offSet) );
            offSet +=icon.Height + 5;

            graphic.DrawString(CompanyName,new Font("Courier New",18),new SolidBrush(Color.Black),startX,startY+offSet );
            offSet += (int)fontHeight + 5;

            string header =
                $"{"Name".PadRight(20)}{"Price".PadRight(8)}{"Quantity".PadRight(10)}{"Total".PadRight(8)}";
            graphic.DrawString(header, new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY + offSet);

            offSet += (int)fontHeight + 5;

            graphic.DrawLine(new Pen(Color.Black),startX,startY+offSet,startX+1000,startY+offSet);

            offSet += 5;

            foreach (var salesItem in Bill.SalesItem)
            {
                string details =
                    $"{salesItem.Name.PadRight(20)}{salesItem.Price.ToString("N0").PadRight(8)}{salesItem.Quantity.ToString("N0").PadRight(10)}{salesItem.TotalPrice.ToString("N0").PadRight(8)}";
                graphic.DrawString(details, new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY+offSet);
                offSet += (int)fontHeight + 5;

            }

            graphic.DrawLine(new Pen(Color.Black), startX, startY + offSet, startX + 1000, startY + offSet);

           // offSet += (int)fontHeight + 5;

            string total =
                $"{"Total".PadRight(20)}{Bill.Total.ToString("N0").PadLeft(21)}";
            graphic.DrawString(total, new Font("Courier New", 18), new SolidBrush(Color.Black), startX, startY + offSet);
            

        }
    }
}
