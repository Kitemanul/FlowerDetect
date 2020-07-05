using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using AForge.Controls;
using AForge.Video;
using AForge.Imaging;

using AForge.Video.DirectShow;
using System.Drawing.Imaging;
using System.Windows.Media.Imaging;
using System.IO;
using System.Windows;
using HalconDotNet;

namespace FlowerDetect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;//设置该属性 为false
        }
        FilterInfoCollection videoDevices;
        Object locker = new Object();


        public int selectedDeviceIndex = 0;



        private void button1_Click(object sender, EventArgs e)
        {

            VideoCaptureDevice videoSource = new VideoCaptureDevice(videoDevices[tscbxCameras.SelectedIndex].MonikerString);
            videoSource.DesiredFrameSize = new System.Drawing.Size(320, 240);
            videoSource.DesiredFrameRate = 1;

            videoSourcePlayer1.SignalToStop();
            videoSourcePlayer1.WaitForStop();
            videoSourcePlayer1.VideoSource = videoSource;
            videoSourcePlayer1.Start();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            videoSourcePlayer1.SignalToStop();
            videoSourcePlayer1.WaitForStop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // 枚举所有视频输入设备
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                if (videoDevices.Count == 0)
                    throw new ApplicationException();

                foreach (FilterInfo device in videoDevices)
                {
                    tscbxCameras.Items.Add(device.Name);
                }

                tscbxCameras.SelectedIndex = 0;

            }
            catch (ApplicationException)
            {
                tscbxCameras.Items.Add("No local capture devices");
                videoDevices = null;
            }
        }

        private void button_captrue_Click(object sender, EventArgs e)
        {
            try
            {
                if (videoSourcePlayer1.IsRunning)
                {
                    BitmapSource bitmapSource = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
                                    videoSourcePlayer1.GetCurrentVideoFrame().GetHbitmap(),
                                    IntPtr.Zero,
                                    Int32Rect.Empty,
                                    BitmapSizeOptions.FromEmptyOptions());
                    PngBitmapEncoder pE = new PngBitmapEncoder();
                    pE.Frames.Add(BitmapFrame.Create(bitmapSource));
                    string picName = GetImagePath() + "\\" + "xiaosy" + ".png";
                    if (File.Exists(picName))
                    {
                        File.Delete(picName);
                    }
                    using (Stream stream = File.Create(picName))
                    {
                        pE.Save(stream);
                    }
                    //拍照完成后关摄像头并刷新同时关窗体                    

                }
                pictureBox1.Image = AForge.Imaging.Image.FromFile("PersonImg\\xiaosy.bmp");
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

                Thread thread = new Thread(new ParameterizedThreadStart(ProcessImage));
                thread.Start(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show("摄像头异常：" + ex.Message);
            }
        }

        private string GetImagePath()
        {
            string personImgPath = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory)
                         + Path.DirectorySeparatorChar.ToString() + "PersonImg";
            if (!Directory.Exists(personImgPath))
            {
                Directory.CreateDirectory(personImgPath);
            }

            return personImgPath;
        }
          
        private void ProcessImage(Object ob)
        {

           lock (locker)
          {
            HDevelopExport hd = new HDevelopExport();
            HTuple res = hd.RunHalcon((bool)ob);

            String[] date = res.ToString().Remove(0,1).Remove(res.ToString().Length-2,1).Split(',');
            setvalue(date);
          } 

        }
        private void setvalue(String[] date)
        {
            A1.Text = date[0].Trim();
            A2.Text = date[1].Trim();
            B1.Text = date[2].Trim();
            B2.Text = date[3].Trim();
            C1.Text = date[4].Trim();
            C2.Text = date[5].Trim();
            C3.Text = date[6].Trim();
            C4.Text = date[7].Trim();
            paozhenwei.Text = date[9].Trim();
            qingxiejiaodu.Text = date[8].Trim();
         


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Button_save_Click(object sender, EventArgs e)
        {

        }

        private void button_process_Click(object sender, EventArgs e)
        {

            Thread thread = new Thread(new ParameterizedThreadStart(ProcessImage));
            thread.Start(false);

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
