using Accord.Imaging;
using Accord.Imaging.Filters;
using IPHW7.Process;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPHW7
{
	public partial class Form1 : Form
	{
		public static Bitmap bInput;
		public Form1()
		{
			InitializeComponent();
		}

		private void btn_Click(object sender, EventArgs e)
		{
			Button btn = sender as Button;
			switch (btn.Name.ToLower())
			{
				case "btnchoose":
					Reset(0);
					ofdChooseImage.CheckFileExists = true;
					ofdChooseImage.CheckPathExists = true;
					if (pbInput.Image != null)
						pbInput.Image.Dispose();
					if (ofdChooseImage.ShowDialog() != DialogResult.OK)
						return;
					txtFile.Text = ofdChooseImage.FileName;
					bInput = new Bitmap(ofdChooseImage.FileName);
					pbInput.Image = bInput;
					break;
				case "btnreset":
					txtFile.Clear();
					Reset(0);
					break;
				case "b":
					break;
				case "c":
					break;
				case "d":
					break;
			}
		}
		public void Reset(int type)
		{
			switch (type)
			{
				case 1:
					if (pbInput.Image != null)
					{
						pbInput.Image.Dispose();
						pbInput.Image = null;
						pbInput.Update();
					}
					break;
				case 2:
					if (pbOutput.Image != null)
					{
						pbOutput.Image.Dispose();
						pbOutput.Image = null;
						pbOutput.Update();
					}

					break;
				case 0:
					Reset(1);
					Reset(2);
					break;
			}
		}

		private void btnProcess_Click(object sender, EventArgs e)
		{
			//Reset picturebox OUTPUT
			Reset(2);
			//Re-size of pickture 
			pictureBox_SizeChanged(pbOutput);
			////
			double sigma = double.Parse(txtSigma.Text);
			double k = double.Parse(txtK.Text);
			double threshold = double.Parse(txtThreshold.Text);

			//// Create a new Harris Corners Detector using the given parameters
			//HarrisCornersDetector harris = new HarrisCornersDetector(k)
			//{
			//	Measure = HarrisCornerMeasure.Harris,
			//	Threshold = threshold,
			//	Sigma = sigma
			//};

			//// Create a new AForge's Corner Marker Filter
			//CornersMarker corners = new CornersMarker(harris, Color.White);

			//// Apply the filter and display it on a picturebox
			//pbOutput.Image = corners.Apply(bInput);

			double[,] GrayScale = Common.ConvertTograyScale(bInput);
			pbOutput.Image = Common.ConvertToBitmap(Common.Thresholding(Common.ComputeAtPixel(GrayScale, k, sigma),double.Parse(txtThreshold.Text)));

		}
		private void pictureBox_SizeChanged(PictureBox pb)
		{
			if (pb.Width < bInput.Width && pb.Height < bInput.Height)
				pb.SizeMode = PictureBoxSizeMode.Zoom;
			else
				pb.SizeMode = PictureBoxSizeMode.Normal;
			pb.Update();
		}
		private void txtParametter_TextChanged(object sender, EventArgs e)
		{
			if (txtK.Text != "" && txtThreshold.Text != "" && txtSigma.Text != "")
			{
				btnProcess.Enabled = true;
			}
			else
				btnProcess.Enabled = false;
		}
		private void txtParametter_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != Char.Parse("."))
				e.Handled = true;
		}
	}
}
