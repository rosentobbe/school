using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace Store
{
    class ReceiptHandler
    {
        Font printFont = new Font("Consolas", 10);
        string toPrint;
        PrintDocument PD = new PrintDocument();
        static String Recipt_format = "{0,-8} {1,-50} {2,-12} {3,-9}";
        private int MAX_P_NAME = 45;
        int count = 0;
        int loopCount = 0;

        //When triggered it asks the User if they want a receipt or not. 
        //Will let the User select printer.
        public void printRecipt(List<Product> products, string totalSum)
        {
            toPrint = preparePrint(products, totalSum);
            try
            {
                PD.PrintPage += new PrintPageEventHandler(this.document_Print);

                PrintDialog printdlg = new PrintDialog();
                printdlg.Document = PD;
                if(MessageBox.Show("Do your want a receipt?", "Receipt?", MessageBoxButtons.YesNo) == DialogResult.Yes && printdlg.ShowDialog() == DialogResult.OK)
                    PD.Print();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show("Couldn't print receipt!");
            }
        }

        //Prepares the structure of the receipt and adds all products to a string.
        private string preparePrint(List<Product> productsInCart, string totalSum)
        {
            string preparePrint = "Receipt from purchase made - " + DateTime.Now.ToString() + "\n\n";
            preparePrint += "Thanks for shopping at my store!\n\n";
            preparePrint += String.Format(Recipt_format + "\n", "ID", "Name", "Price (€)", "Balance");
            string temp_name;
            foreach (Product x in productsInCart)
            {
                loopCount++;
                if (x.Name.Length < MAX_P_NAME)
                    temp_name = x.Name;
                else
                    temp_name = x.Name.Substring(0, MAX_P_NAME) + "...";
                preparePrint += String.Format(Recipt_format + "\n", x.P_ID, temp_name, x.Price, x.Balance);
            }
            preparePrint = preparePrint + "\nTotal price = " + totalSum + " €";
            return preparePrint;
        }

        //Splits the string containg all bought products. Then adds them line by line into a document that are to be printed.
        //It will count number of lines added so that it can print on several pages if many products have been bought.
        private void document_Print(object sender, PrintPageEventArgs ev)
        {
            float linesPerPage = 0;
            float yPos = 0;
            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;
            string line = null;
            int temp_count = 0;
            string[] linesToWrite = toPrint.Split('\n');
            int numLines = linesToWrite.Length;
            
            linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics);
            while (temp_count < linesPerPage && count < numLines)
            {
                line = linesToWrite[count];
                yPos = topMargin + (temp_count * printFont.GetHeight(ev.Graphics));
                ev.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, yPos, new StringFormat());
                temp_count++;
                count++;

            }
            if (count < numLines)
            {
                ev.HasMorePages = true;
                return;
            }
            else
                ev.HasMorePages = false;
           
        }
    }
}
