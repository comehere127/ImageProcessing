using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
			DrawingCircles(lbGrayScale, 20);
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
					bInput = new Bitmap(ofdChooseImage.FileName);
					pbInput.Image = bInput;
					break;
				case "btnreset":
					txtFile.Clear();
					break;
				case "btnProcess":
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
			l.BackColor = Color.Red;
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
					}
					if (pbDY.Image != null)
					{
						pbDY.Image.Dispose();
						pbDY.Image = null;
					}
					if (pbSED.Image != null)
					{
						pbSED.Image.Dispose();
						pbSED.Image = null;
					}
					if (pbTheshold.Image != null)
					{
						pbTheshold.Image.Dispose();
						pbTheshold.Image = null;
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

		}
	}
}
