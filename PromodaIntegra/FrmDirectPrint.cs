using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PromodaIntegra
{
    public partial class FrmDirectPrint : Form
    {
        public FrmDirectPrint()
        {
            InitializeComponent();

            LoadPrinterList();
        }

        private void LoadPrinterList()
        {
            cbxPrinters.Items.Clear();

            foreach (var printer in System.Drawing.Printing.PrinterSettings.InstalledPrinters)
            {
                cbxPrinters.Items.Add(printer);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                printDocument.PrinterSettings.PrinterName = cbxPrinters.SelectedItem.ToString();
                try
                {
                    printDocument.Print();
                }
                catch (Exception)
                {
                    MessageBox.Show("Unable to print, search for system administrator!");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Select a printer!");
            }

            
            
           
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap printTag = new Bitmap(this.pnlPrint.Width, this.pnlPrint.Height);
            //printTag.SetResolution(300.0F, 300.0F);
            pnlPrint.DrawToBitmap(printTag, new Rectangle(0, 0, this.pnlPrint.Width, this.pnlPrint.Height));
            e.Graphics.DrawImage(printTag, 0, 0);
        }

        
    }
}
