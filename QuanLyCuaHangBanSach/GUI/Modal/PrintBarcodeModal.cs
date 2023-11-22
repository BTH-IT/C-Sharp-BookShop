using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using QuanLyCuaHangBanSach.GUI.Report;
using ZXing;

namespace QuanLyCuaHangBanSach.GUI.Modal
{
    public partial class PrintBarcodeModal : Form
    {
        public PrintBarcodeModal(string ma)
        {
            InitializeComponent();

            guna2TextBox1.Text = ma;
        }

        private void submitBtn_Click(object sender, EventArgs e)
        {
            BookDTO book = BookBUS.Instance.getById(guna2TextBox1.Text);
            Bitmap largerBarcodeBitmap = GenerateBarcodeWithText(guna2TextBox1.Text, string.Format("{0:N0} VNĐ", book.GiaBan));
            pictureBox1.Image = largerBarcodeBitmap;
            this.barcodeDataSet1.Clear();
            System.Data.DataTable dataTable = this.barcodeDataSet1.Tables[0];
            using (MemoryStream ms = new MemoryStream())
            {
                
                largerBarcodeBitmap.Save(ms, ImageFormat.Png);
                for (int i = 0; i < this.number.Value; i++)
                {
                    dataTable.Rows.Add(ms.ToArray());
                }

                this.bindingSource1.DataSource = dataTable;
            }

            using (BarcodePrintForm barcodePrintForm = new BarcodePrintForm(dataTable))
            {
                barcodePrintForm.ShowDialog();
            }
        }

        public static Bitmap GenerateBarcodeWithText(string ma, string price)
        {
            // Create an instance of the BarcodeWriter class
            BarcodeWriter barcodeWriter = new BarcodeWriter();

            // Set the barcode format to CODE_128, but you can choose other formats
            barcodeWriter.Format = BarcodeFormat.CODE_128;

            // Generate the barcode image
            Bitmap barcodeBitmap = barcodeWriter.Write(ma);

            // Set a larger size for the barcode image to allow space for text
            int largerWidth = Math.Max(barcodeBitmap.Width, 200);
            int largerHeight = barcodeBitmap.Height + 40;
            Bitmap largerBarcodeBitmap = new Bitmap(largerWidth, largerHeight);

            // Draw the barcode onto the larger bitmap
            using (Graphics g = Graphics.FromImage(largerBarcodeBitmap))
            {
                g.Clear(Color.White);
                g.DrawImage(barcodeBitmap, new Point((largerWidth - barcodeBitmap.Width) / 2, 0));
            }

            // Draw the price below the barcode
            using (Graphics g = Graphics.FromImage(largerBarcodeBitmap))
            {
                // Set font and brush for the price text
                Font font = new Font("Arial", 10);
                Brush brush = new SolidBrush(Color.Black);

                // Measure the size of the text to ensure it fits within the width of the barcode
                SizeF textSize = g.MeasureString(price, font);
                float textX = (largerBarcodeBitmap.Width - textSize.Width) / 2;
                float textY = barcodeBitmap.Height + 10;

                // Display the price
                g.DrawString(price, font, brush, new PointF(textX, textY));
            }

            return largerBarcodeBitmap;
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            BookDTO book = BookBUS.Instance.getById(guna2TextBox1.Text);
            Bitmap largerBarcodeBitmap = GenerateBarcodeWithText(guna2TextBox1.Text, string.Format("{0:N0} VNĐ", book.GiaBan));
            pictureBox1.Image = largerBarcodeBitmap;
        }
    }
}
