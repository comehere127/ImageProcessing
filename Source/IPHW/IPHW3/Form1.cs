using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPHW3
{
	public partial class Form1 : Form
	{
		public Bitmap bInput;
		public Form1()
		{
			InitializeComponent();
			cbMatrix.SelectedIndex = cbType.SelectedIndex = 0;
		}

		private void btnChoose_Click(object sender, EventArgs e)
		{
			openFileDialog1.CheckFileExists = true;
			openFileDialog1.CheckPathExists = true;
			if (pbInput.Image != null)
				pbInput.Image.Dispose();
			if (openFileDialog1.ShowDialog() != DialogResult.OK)
				return;
			txtFile.Text = openFileDialog1.FileName;
			bInput = new Bitmap(openFileDialog1.FileName);
			pbInput.Image = bInput;
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			if (pbInput.Image != null )
			{
				pbInput.Image.Dispose();
				 pbInput.Image = null;
			}
			if(pbOutput.Image != null)
			{
				pbOutput.Image.Dispose();
				pbOutput.Image = null;
			}
			cbMatrix.SelectedIndex = cbType.SelectedIndex = 0;
			txtFile.Clear();
		}

		private void btnExecute_Click(object sender, EventArgs e)
		{
			int matrixSize = 3;
			int type = cbType.SelectedIndex;
			if (matrixSize > 0)
			{
				pbOutput.Image = MedianFilter(new Bitmap(txtFile.Text), matrixSize, type);
			}else
			{
				if (pbOutput.Image != null)
				{
					pbOutput.Image.Dispose();
					pbOutput.Image = null;
				}
				pbOutput.Image = new Bitmap(txtFile.Text);
			}
		}

		private Bitmap MedianFilter(Bitmap source, int matrixSize, int type)
		{
			List<byte> termsList = new List<byte>();
			matrixSize = matrixSize * 2 + 1;
			byte[,] image = new byte[source.Width, source.Height];
			//Convert to Grayscale 
			for (int i = 0; i < source.Width; i++)
			{
				for (int j = 0; j < source.Height; j++)
				{
					var c = source.GetPixel(i, j);
					byte gray = (byte)(0.299 * c.R + 0.587 * c.G + 0.114 * c.B);
					image[i, j] = gray;
				}
			}
			//applying Median Filtering 
			for (int i = 0; i <= source.Width - matrixSize; i++)
				for (int j = 0; j <= source.Height - matrixSize; j++)
				{
					for (int x = i; x <= i + matrixSize-1; x++)
						for (int y = j; y <= j + matrixSize-1; y++)
						{
							termsList.Add(image[x, y]);
						}
					byte[] terms = termsList.ToArray();
					termsList.Clear();
					Array.Sort<byte>(terms);
					Array.Reverse(terms);
					byte color;
					switch (type)
					{
						case 1: color = terms[8]; break;
						case 2: color = terms[0]; break;
						default: color = terms[4]; break;
					}
					source.SetPixel(i + 1, j + 1, Color.FromArgb(color, color, color));
				}
			return source;
		}
	}
}
