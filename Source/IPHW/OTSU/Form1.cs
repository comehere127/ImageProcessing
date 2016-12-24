using OTSU.Process;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTSU
{
	public partial class Form1 : Form
	{
		public Bitmap bInput;
		public Form1()
		{
			InitializeComponent();
		}

		private void btnChoose_Click(object sender, EventArgs e)
		{
			openFileDialog1.CheckFileExists = true;
			openFileDialog1.CheckPathExists = true;
			if (pbInput.Image != null)
				pbInput.Image.Dispose();
			if (openFileDialog1.ShowDialog() != DialogResult.OK)
				return;
				bInput = new Bitmap(openFileDialog1.FileName);
				pbInput.Image = bInput;
			txtOtsuThreshold.Text = Common.GetOtsuThreshold(Common.ConvertTograyScale(bInput)).ToString();


		}
	}
}
