using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IPTools
{
    public partial class MainForm : Form
    {
        Bitmap anhGoc;
        Bitmap anhKetQua;
        ImageClass image = new ImageClass();
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void LoadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                anhGoc = new Bitmap(dlgOpen.FileName);
                anhKetQua = new Bitmap(dlgOpen.FileName);
                PicGoc.Image = anhGoc;

                //GrayTransform_Click(sender, e);
            }
        }

        private void GrayTransform_Click(object sender, EventArgs e)
        {
            image.Gray(anhKetQua);
            PicKetqua.Image = anhKetQua;
        }

        private void NegativeT_Click(object sender, EventArgs e)
        {
            image.NegativeT(anhKetQua);
            PicKetqua.Image = anhKetQua;
        }
        
        private void LogT_Click(object sender, EventArgs e)
        {
            image.LogT(anhKetQua);
            PicKetqua.Image = anhKetQua;
        }

        private void PowerT_Click(object sender, EventArgs e)
        {
            image.PowerT(anhKetQua,0.5);
            PicKetqua.Image = anhKetQua;
        }

        private void PiecewiseLinearT_Click(object sender, EventArgs e)
        {
            image.PiecewiseLinearT(anhKetQua);
            PicKetqua.Image = anhKetQua;
        }

        private void BitPlane1_Click(object sender, EventArgs e)
        {
            image.BitsPlaneExt(anhKetQua,2);
            PicKetqua.Image = anhKetQua;
        }

        private void HisEqua_Click(object sender, EventArgs e)
        {
            image.HistogramEqu(anhKetQua);
            PicKetqua.Image = anhKetQua;
        }

        private void HistogramMatching_Click(object sender, EventArgs e)
        {
            image.HistogramMatching(anhKetQua);
            PicKetqua.Image = anhKetQua;
        }

        private void HistogramStatistic_Click(object sender, EventArgs e)
        {
            image.HistogramStatistic(anhKetQua);
            PicKetqua.Image = anhKetQua;
        }

        private void LogicalProcess_Click(object sender, EventArgs e)
        {
            anhGoc = new Bitmap("D:\\Giangday\\0708ky1\\Xu ly anh - Tin39\\IPTools\\Image\\ROSE.JPG");
            Bitmap Doituong = new Bitmap("D:\\Giangday\\0708ky1\\Xu ly anh - Tin39\\IPTools\\Image\\Doituong.BMP");
            Bitmap AnhNen = new Bitmap("D:\\Giangday\\0708ky1\\Xu ly anh - Tin39\\IPTools\\Image\\ROSE.JPG");
            Bitmap AnhOr = new Bitmap("D:\\Giangday\\0708ky1\\Xu ly anh - Tin39\\IPTools\\Image\\ROSE_or.BMP");
            Bitmap AnhAnd = new Bitmap("D:\\Giangday\\0708ky1\\Xu ly anh - Tin39\\IPTools\\Image\\ROSE_And.BMP");

            //anhGoc = new Bitmap("D:\\Giangday\\0708ky1\\Xu ly anh - Tin39\\IPTools\\Image\\Xuongrong.JPG");
            //Bitmap Doituong = new Bitmap("D:\\Giangday\\0708ky1\\Xu ly anh - Tin39\\IPTools\\Image\\Doituong.BMP");
            //Bitmap AnhNen = new Bitmap("D:\\Giangday\\0708ky1\\Xu ly anh - Tin39\\IPTools\\Image\\Xuongrong.JPG");
            //Bitmap AnhOr = new Bitmap("D:\\Giangday\\0708ky1\\Xu ly anh - Tin39\\IPTools\\Image\\OrImage.BMP");
            //Bitmap AnhAnd = new Bitmap("D:\\Giangday\\0708ky1\\Xu ly anh - Tin39\\IPTools\\Image\\AndImage.BMP");

            //image.Gray(AnhNen);           //image.Gray(AnhOr);            //image.Gray(AnhAnd);

            PicGoc.Image = anhGoc ;
            PicDoituong.Image = Doituong;

            image.LogicOperators(AnhNen ,AnhOr,AnhAnd);

            PicKetqua.Image = AnhNen;
        }

        private void Subtraction_Click(object sender, EventArgs e)
        {
            anhGoc = new Bitmap("D:\\Giangday\\0708ky1\\Xu ly anh - Tin39\\IPTools\\Image\\ROSE.JPG");
            anhKetQua  = new Bitmap("D:\\Giangday\\0708ky1\\Xu ly anh - Tin39\\IPTools\\Image\\ROSE.JPG");
            //Bitmap Doituong = new Bitmap("D:\\Giangday\\0708ky1\\Xu ly anh - Tin39\\IPTools\\Image\\Doituong.BMP");
            Bitmap Doituong = new Bitmap("D:\\Giangday\\0708ky1\\Xu ly anh - Tin39\\IPTools\\Image\\RoseLogo.JPG");
            

            //image.Gray(anhKetQua);  
            //image.Gray(Doituong);

            PicGoc.Image = anhGoc;
            PicDoituong.Image = Doituong;

            image.Subtraction(anhKetQua,Doituong);

            PicKetqua.Image = anhKetQua;
        }

        private void AverageImage_Click(object sender, EventArgs e)
        {
            anhGoc = new Bitmap("D:\\Giangday\\0708ky1\\Xu ly anh - Tin39\\IPTools\\Image\\NGCGalaxy.BMP");
            anhKetQua = new Bitmap("D:\\Giangday\\0708ky1\\Xu ly anh - Tin39\\IPTools\\Image\\NGCGalaxy.BMP");
            Bitmap doituong = new Bitmap("D:\\Giangday\\0708ky1\\Xu ly anh - Tin39\\IPTools\\Image\\NGCGalaxyNoise.BMP");
            
            image.Gray(anhKetQua);
            image.Gray(doituong);  

            PicGoc.Image = anhGoc;
            PicDoituong.Image = doituong;

            image.Average(anhKetQua,doituong,128);

            PicKetqua.Image = anhKetQua;
        }

        private void FourierTransform_Click(object sender, EventArgs e)
        {
            image.FourierTrans(anhKetQua,ImageClass.FourierDirection.Forward);
            //image.LogT(anhKetQua);
            PicKetqua.Image = anhKetQua;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            image.FourierTrans(anhKetQua,ImageClass.FourierDirection.Backward);
            //image.LogT(anhKetQua);
            PicKetqua.Image = anhKetQua;
        }

        private void Gradient_Click(object sender, EventArgs e)
        {
            image.Gradient(anhKetQua);
            PicKetqua.Image = anhKetQua;
        }

        private void Segment_Click(object sender, EventArgs e)
        {
            image.SegmentFixd(anhKetQua,250);
            PicKetqua.Image = anhKetQua;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveImage = new SaveFileDialog();
            SaveImage.ShowDialog();
            anhKetQua.Save(SaveImage.FileName);
        }

        private void AverageFilter_Click(object sender, EventArgs e)
        {
            image.AverageFilter(anhKetQua);
            PicKetqua.Image = anhKetQua;
            //MessageBox.Show("xong");
        }

        private void PicGoc_MouseMove(object sender, MouseEventArgs e)
        {
            //this.Text = anhGoc.GetPixel(65, 185).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            image.SegmentLap(anhKetQua);
            PicKetqua.Image = anhKetQua;
        }
    }
}