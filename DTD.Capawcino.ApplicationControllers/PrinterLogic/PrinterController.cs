using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using DTD.Capawcino.Entities;
using ESCPOS_NET;
using ESCPOS_NET.Emitters;
using ESCPOS_NET.Utilities;

namespace DTD.Capawcino.ApplicationControllers.PrinterLogic
{
    public class PrinterController
    {
        private Bill Bill { get; set; }
        private string LogoPath { get; set; }
        private string CompanyName { get; set; }
        private string CompanyLocation { get; set; }
        private string CompanyContactInfo { get; set; }



        private  BasePrinter _printer;
        private  ICommandEmitter _e;


        public void PrintReceiptForTransaction(Bill bill)
        {
            Bill = bill;
            _e=new EPSON();
            CompanyName = "Capawcino Cat Cafe";
            CompanyLocation = @"Capawcino Cat Cafe, House: C52, Block: C, Road: W1, Eastern Housing Pallabi, Dhaka 1216";
            CompanyContactInfo = "01912995783";
            LogoPath = @"C:\Users\BS_269\Downloads\cropped-bs-logo-1.png";
            File.WriteAllBytes(@"C:\Users\BS_269\Desktop\New folder\bill.txt", Receipt(_e));
        }

        private void PrepareNetworkPrinter(string ip,string networkPort)
        {
            _printer = new NetworkPrinter(ip, int.Parse(networkPort));
            _e = new EPSON();
        
            _printer.Write(Receipt(_e));
        

        }

        private byte[] Receipt(ICommandEmitter e)
        {
            
            byte[] data=ByteSplicer.Combine(
                e.CenterAlign(),
                e.PrintLine(),
                e.PrintLine(CompanyName),
                e.PrintLine(CompanyLocation),
                e.PrintLine(CompanyContactInfo),
                e.SetStyles(PrintStyle.Underline),
                e.PrintLine("www.link.com"),
                e.SetStyles(PrintStyle.None),
                e.PrintLine(),
                e.LeftAlign(),
                e.PrintLine()
            );

            
            data = ByteSplicer.Combine(data,
                e.PrintLine(
                    $"{"Product",-40}{"Price",6}{"Quantity",9}{"Total",9}"));

            foreach (var salesItem in Bill.SalesItem)
            {
                data = ByteSplicer.Combine(data,
                    e.PrintLine(
                        $"{salesItem.Name,-40}{salesItem.Price,6}{salesItem.Quantity,9}{salesItem.TotalPrice,9:N2}"));
            }


            data = ByteSplicer.Combine(data,
                e.PrintLine($"{"Total",-40}{Bill.Total,24:N2}")
                );

            e.LeftAlign();
            e.PrintLine();
            e.PrintLine();
            e.PartialCut();
            
            return data;
        }

    }
}
