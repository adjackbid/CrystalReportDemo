using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;

using ZXing.Datamatrix;
using ZXing;
using System.IO;

namespace CrystalReportDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                string sFrom = ttbFrom.Text.Trim();
                string sTo = ttbTo.Text.Trim();
                string sWeight = ttbWeight.Text.Trim();
                string sItemNo = ttbItemNo.Text.Trim();

                //fake img
                //byte[] imageArray = System.IO.File.ReadAllBytes(@"test.jpg");
                byte[] imageArray = DataMatrixCreater($"FN{sFrom}TO{sTo}WT{sWeight}IN{sItemNo}");

                PrintLabel(sFrom, sTo, sWeight, sItemNo, imageArray);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private byte[] DataMatrixCreater(string sText)
        {
            
            BarcodeWriter barcode = new BarcodeWriter();
            barcode.Format = BarcodeFormat.DATA_MATRIX;
            byte[] result = null;

            //barcode.Write(sText).Save("test3.jpg");
            //result = System.IO.File.ReadAllBytes("test3.jpg");

            Bitmap bQrcode = barcode.Write(sText);
            result = ImageToByte(bQrcode);
            return result;
        }
        public byte[] ImageToByte(Image img)
        {
            using (var stream = new MemoryStream())
            {
                img.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                return stream.ToArray();
            }
        }


        private void PrintLabel(string sFrom, string sTo, string sWeight, string sItemNo,byte[] img)
        {
            DSLabel ds = new DSLabel();

            //CREATE DataTable
            DataTable dt = ds.Tables[0];
            DataRow dr_row = null;
            dr_row = dt.NewRow();
            dr_row["FROM"] = sFrom;
            dr_row["TO"] = sTo;
            dr_row["WEIGHT"] = sWeight;
            dr_row["ITEMNO"] = sItemNo;
            dr_row["QRCODE"] = img;
            dt.Rows.Add(dr_row);

            //Create CR Report Object
            ReportDocument doc = new CRLabel();
            doc.SetDataSource(ds);

            //Print
            doc.PrintToPrinter(1, false, 0, 0);
        }
    }
}
