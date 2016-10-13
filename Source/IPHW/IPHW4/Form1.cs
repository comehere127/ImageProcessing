using IPHW4.Process;
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

namespace IPHW4
{
	public partial class Form1 : Form
	{
		public static Bitmap bInput;
		public Form1()
		{
			InitializeComponent();
			DrawingCircles(lbStatus,50);
		}
		private void btnClick(object sender, EventArgs e)
		{
			Button btn = sender as Button;
			Reset(0);
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
					rbRolation.Checked = rbZoom.Checked = false;
					cbIndex.DataSource = null;
					cbIndex.Enabled = false;
					lbStatus.BackColor = SystemColors.Control;
					break;
				case "b":
					break;
				case "c":
					break;
				case "d":
					break;
			}
			
		}

		private List<String> ListData(String type)
		{
			List<String> lstData = new List<string>();

			switch (type.ToLower())
			{
				case "rolate":
					lstData.Add("30ᵒ");
					lstData.Add("45ᵒ");
					break;
				case "zoom":
					lstData.Add("30%");
					lstData.Add("50%");
					lstData.Add("100%");
					lstData.Add("200%");
					lstData.Add("250%");
					break;
			}

			return lstData;
		}

		private void rbChecked(object sender, EventArgs e)
		{
			btnProcess.Enabled = cbIndex.Enabled = true;
			Reset(2);
			if (rbRolation.Checked)
			{
				cbIndex.DataSource = ListData("rolate");
			}
			else
				cbIndex.DataSource = ListData("zoom");
		}
		private void button1_Click(object sender, EventArgs e)
		{
			Reset(2);
			SetColor(lbStatus, Color.Red);
			string value = new String(cbIndex.SelectedValue.ToString().ToCharArray().Where(c => Char.IsNumber(c)).ToArray());
			if (rbRolation.Checked)
			{
				switch(value)
				{
					case "30":
						pbOutputBL.Image = BilinearInterpolation.Rotate(bInput, Math.PI / 6);
						SetColor(lbStatus, Color.Green);
						break;
					case "45":
						pbOutputBL.Image = BilinearInterpolation.Rotate(bInput,Math.PI / 4);
						SetColor(lbStatus, Color.Green);
						break;
				}
			}
			else
			{
				switch (value)
				{
					case "30":
						
						pbOutputNN.Image = NearestNeighborInterpolation.Scale(bInput, (float)1/3);
						pbOutputBL.Image = BilinearInterpolation.Scale(bInput, (float)1 / 3);
						SetColor(lbStatus, Color.Green);
						break;
					case "50":
						pbOutputNN.Image = NearestNeighborInterpolation.Scale(bInput, (float)1 / 2);
						pbOutputBL.Image = BilinearInterpolation.Scale(bInput, (float)1 / 2);
						SetColor(lbStatus, Color.Green);
						break;
					case "100":
						pbOutputNN.Image = NearestNeighborInterpolation.Scale(bInput, (float)1);
						pbOutputBL.Image = BilinearInterpolation.Scale(bInput, (float)1);
						SetColor(lbStatus, Color.Green);
						break;
					case "200":
						pbOutputNN.Image = NearestNeighborInterpolation.Scale(bInput, (float)2);
						pbOutputBL.Image = BilinearInterpolation.Scale(bInput, (float)2);
						SetColor(lbStatus, Color.Green);
						break;
					case "250":
						pbOutputNN.Image = NearestNeighborInterpolation.Scale(bInput, (float)2.5);
						pbOutputBL.Image = BilinearInterpolation.Scale(bInput, (float)2.5);
						SetColor(lbStatus, Color.Green);
						break;
				}
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
					}
					break;
				case 2:
					if (pbOutputBL.Image != null)
					{
						pbOutputBL.Image.Dispose();
						pbOutputBL.Image = null;
					}
					if (pbOutputNN.Image != null)
					{
						pbOutputNN.Image.Dispose();
						pbOutputNN.Image = null;
					}
					break;
				case 0:
					Reset(1);
					Reset(2);
					break;
			}
		}
		private void DrawingCircles(Label l,int size)
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
	}
}
