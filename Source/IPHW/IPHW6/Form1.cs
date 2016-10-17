using IPHW4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPHW6
{
	public partial class Form1 : Form
	{
		public static Bitmap bInput;
		public Form1()
		{
			InitializeComponent();
			DrawingCircles(lbfx,20);
			DrawingCircles(lbfy, 20);
			DrawingCircles(lbSED, 20);
			DrawingCircles(lbThreshold, 20);
		}
		private void btnClick(object sender, EventArgs e)
		{
			Button btn = sender as Button;
			switch (btn.Name.ToLower())
			{
				case "btnchoose":
					ofdChooseImage.CheckFileExists = true;
					ofdChooseImage.CheckPathExists = true;
					if (pbInput.Image != null)
						pbInput.Image.Dispose();
					if (ofdChooseImage.ShowDialog() != DialogResult.OK)
						return;
					txtFile.Text = ofdChooseImage.FileName;
					if (txtFile.Text != "")
						txtThreshold.ReadOnly = false;
					bInput = new Bitmap(ofdChooseImage.FileName);
					pbInput.Image = bInput;
					break;
				case "btnreset":
					txtFile.Clear();
					txtThreshold.Clear();
					txtThreshold.ReadOnly = true;
					Reset(0);
					SetColor(lbfx, Color.Transparent);
					SetColor(lbfy, Color.Transparent);
					SetColor(lbSED, Color.Transparent);
					SetColor(lbThreshold, Color.Transparent);
					break;
				case "b":
					break;
				case "c":
					break;
				case "d":
					break;
			}
		}

		private void DrawingCircles(Label l, int size)
		{
			l.Size = new Size(size, size);
			l.AutoSize = false;
			GraphicsPath p = new GraphicsPath();
			p.AddEllipse(0, 0, size, size);
			l.Region = new Region(p);
			p.Dispose();
		}

		private void SetColor(Label l, Color c)
		{
			l.BackColor = c;
			l.Update();
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
					}
					break;
				case 2:
					if (pbDX.Image != null)
					{
						pbDX.Image.Dispose();
						pbDX.Image = null;
						pbDX.Update();
					}
					if (pbDY.Image != null)
					{
						pbDY.Image.Dispose();
						pbDY.Image = null;
						pbDY.Update();
					}
					if (pbSED.Image != null)
					{
						pbSED.Image.Dispose();
						pbSED.Image = null;
						pbSED.Update();
					}
					if (pbTheshold.Image != null)
					{
						pbTheshold.Image.Dispose();
						pbTheshold.Image = null;
						pbTheshold.Update();
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
			Reset(2);
			//Change size mode
			pictureBox_SizeChanged(pbDX);
			pictureBox_SizeChanged(pbDY);
			pictureBox_SizeChanged(pbSED);
			pictureBox_SizeChanged(pbTheshold);

			//byte[,] arrBInput = Common.ConvertTograyScale(bInput);
			SetColor(lbfx, Color.Red);
			SetColor(lbfy, Color.Yellow);
			SetColor(lbSED, Color.Yellow);
			SetColor(lbThreshold, Color.Yellow);
			pbDX.Image = Common.ConvertToBitmap(Common.Convl3x3(bInput, "x"));
			pbDX.Update();
			SetColor(lbfx, Color.Green);
			SetColor(lbfy, Color.Red);
			pbDY.Image = Common.ConvertToBitmap(Common.Convl3x3(bInput, "y"));
			pbDY.Update();
			SetColor(lbfy, Color.Green);
			SetColor(lbSED, Color.Red);
			pbSED.Image = Common.ConvertToBitmap(Common.SobelConvol((Bitmap)pbDX.Image.Clone(), (Bitmap)pbDY.Image.Clone()));
			pbSED.Update();
			SetColor(lbSED, Color.Green);
			SetColor(lbThreshold, Color.Red);
			pbTheshold.Image=Common.ConvertToBitmap(Common.Threshold((Bitmap)pbSED.Image.Clone(),Int32.Parse(txtThreshold.Text)));
			pbTheshold.Update();
			SetColor(lbThreshold, Color.Green);
		}

		private void txtThreshold_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
				e.Handled = true;
		}

		private void txtThreshold_TextChanged(object sender, EventArgs e)
		{
			if (txtThreshold.Text != "")
			{
				btnProcess.Enabled = true;
				if (Int32.Parse(txtThreshold.Text) > 255)
					txtThreshold.Text = "255";
			}
			else
				btnProcess.Enabled = false;
		}

		private void pictureBox_SizeChanged(PictureBox pb)
		{
			if(pb.Width<bInput.Width && pb.Height < bInput.Height)
				pb.SizeMode = PictureBoxSizeMode.Zoom;
			else
				pb.SizeMode = PictureBoxSizeMode.Normal;
			pb.Update();
		}
	}
}
