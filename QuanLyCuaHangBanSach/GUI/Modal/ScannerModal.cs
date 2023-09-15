using System;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using QuanLyCuaHangBanSach.BUS;
using QuanLyCuaHangBanSach.DTO;
using ZXing;

namespace QuanLyCuaHangBanSach.GUI.Modal
{
    public partial class ScannerModal : Form
    {
        public BookDTO scannedBook = null;
        public ScannerModal()
        {
            InitializeComponent();
        }
    
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        private void ScannerModal_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            foreach (FilterInfo device in filterInfoCollection)
            {
                this.cameraCbx.Items.Add(device.Name);
            }

            this.cameraCbx.SelectedIndex = 0;

            this.videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cameraCbx.SelectedIndex].MonikerString);

            this.videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;

            this.videoCaptureDevice.Start();

            this.timer1.Start();

            this.scanBtn.Enabled = false;
        }

        private void scanBtn_Click(object sender, EventArgs e)
        {
            this.videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cameraCbx.SelectedIndex].MonikerString);

            this.videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;

            this.videoCaptureDevice.Start();

            this.timer1.Start();

            this.scanBtn.Enabled = false;
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs e)
        {
            Bitmap bitmap = (Bitmap) e.Frame.Clone();

            Image img = (Image)bitmap;

            img.RotateFlip(RotateFlipType.RotateNoneFlipX);

            this.pictureBox.Image = img;
        }

        private void ScannerModal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.videoCaptureDevice != null)
            {
                if (this.videoCaptureDevice.IsRunning)
                {
                    this.videoCaptureDevice.Stop();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox.Image != null) {

                BarcodeReader reader = new BarcodeReader();

                var result = reader.Decode((Bitmap) pictureBox.Image);

                if (result != null)
                {
                    this.scannedBook = BookBUS.Instance.getById(result.ToString());

                    timer1.Stop();
                    if (this.videoCaptureDevice.IsRunning)
                    {
                        this.videoCaptureDevice.Stop();
                    }
                    this.scanBtn.Enabled = true;
                    pictureBox.Image = null;

                    if (this.scannedBook != null)
                    {
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Mã vạch không có trong hệ thống!! vui lòng thử mã khác!");
                    }
                }
            }
        }

        private void cameraCbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.videoCaptureDevice.Stop();

            this.timer1.Stop();

            this.videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cameraCbx.SelectedIndex].MonikerString);

            this.videoCaptureDevice.NewFrame += VideoCaptureDevice_NewFrame;

            this.videoCaptureDevice.Start();

            this.timer1.Start();

            this.scanBtn.Enabled = false;
        }
    }
}
