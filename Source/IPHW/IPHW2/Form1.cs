using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPHW2
{
	public partial class Form1 : Form
	{
		public Bitmap bInput;
		public string FileName;
		public Form1()
		{
			InitializeComponent();
		}
		private void rbChecked(object sender, EventArgs e)
		{
			RadioButton rb = sender as RadioButton;
			if (rb.Checked)
			{
				Reset(2);
				switch (rb.Name)
				{
					case "rbBlur":
						txtBlur.Visible = lbBlur.Visible = btnExecute.Visible = true;
						break;
					case "rbEmboss":
						break;
					case "rbGauss":
						break;
				}
			}
		}
		private void buttonClick(object sender, EventArgs e)
		{
			Button btn = sender as Button;
			switch (btn.Name)
			{
				case "btnReset":
					rbBlur.Checked = rbEmboss.Checked = rbGauss.Checked = false;
					Reset(0);
					break;
				case "btnChoose":
					openFileDialog1.CheckFileExists = true;
					openFileDialog1.CheckPathExists = true;
					if (pbInput.Image != null)
						pbInput.Image.Dispose();
					if (openFileDialog1.ShowDialog() != DialogResult.OK)
						return;
					FileName = openFileDialog1.FileName;
					bInput = new Bitmap(FileName);
					pbInput.Image = bInput;
					break;
				case "btnExecute":
					int BlurAmount = Int32.Parse(txtBlur.Text);
					MessageBox.Show(BlurAmount.ToString());
					break;
			}
		}
		private Bitmap Emboss(Bitmap source)
		{
			Bitmap bNew = new Bitmap(source.Width, source.Height);
			for(int row = 0; row < source.Width; row++)
			{
				for(int col = 0; col < source.Height; col++)
				{
					bNew.SetPixel(row, col, Color.DarkGray);
				}
			}
			for(int row = 0; row < source.Width; row++)
			{
				for(int col = 0; col < source.Height; col++)
				{
					Color c = bNew.GetPixel(row, col);
					int colval = c.R + c.G + c.B;

				}
			}
			return bNew;
		}
		public void Reset(int type)
		{
			txtBlur.Visible = lbBlur.Visible = btnExecute.Visible = false;
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
					if (pbOutput.Image != null)
					{
						pbOutput.Image.Dispose();
						pbOutput.Image = null;
					}
					break;
				case 0:
					Reset(1);
					Reset(2);
					break;
			}
		}

		private void txtBlur_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
			{
				e.Handled = true;
			}
		}
	}
}
