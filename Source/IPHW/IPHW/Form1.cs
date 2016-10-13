using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IPHW
{
	public partial class Form1 : Form
	{
		public Bitmap bInput;
		public Bitmap hisInput;
		public bool isHisSpe = false;
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
			if (!isHisSpe)
			{
				bInput = new Bitmap(openFileDialog1.FileName);
				pbInput.Image = bInput;
				hisInput = CreateHistogram(bInput, false);
				pbHisInput.Image = hisInput;
			}
			else
			{
				Bitmap bInput2 = new Bitmap(openFileDialog1.FileName);
				hisInput = CreateHistogram(bInput2, false);
				pbHisInput.Image = bInput2;
			}

		}
		private void btnReset_Click(object sender, EventArgs e)
		{
			rbEndInSearch.Checked = rbHistoEqual.Checked = rbHistoSpe.Checked = false;
			Reset(0);
		}
		/// <summary>
		/// Get histogram of image.
		/// 1. Convert to GrayImage 2. Get histogram
		/// </summary>
		/// <param name="source"></param>
		/// <returns></returns>
		unsafe
		public Bitmap CreateHistogram(Bitmap source, bool isGray)
		{
			if (source.PixelFormat == PixelFormat.Format24bppRgb)
			{
				Bitmap histogram = new Bitmap(256, 256, PixelFormat.Format24bppRgb);
				BitmapData bdInput = source.LockBits(new Rectangle(0, 0, source.Width, source.Height), ImageLockMode.ReadWrite, source.PixelFormat);
				//so byte sau khi duoc them - so byte thuoc ve anh khi chua them phan offset
				int offset = bdInput.Stride - source.Width * 3;

				byte* ip = (byte*)bdInput.Scan0;
				if (!isGray)
				{
					for (int i = 0; i < source.Width; i++)
					{
						for (int j = 0; j < source.Height; j++)
						{
							//0.299R+0.587G+0.114B
							byte average = (byte)(0.114f * ip[0] + 0.587f * ip[1] + 0.299f * ip[2]);
							ip[0] = ip[1] = ip[2] = average;
							ip += 3;
						}
						ip += offset;
					}
					ip = (byte*)bdInput.Scan0;
				}
				int[] count = new int[256];
				int max = 0;
				for (int row = 0; row < source.Width; row++)
				{
					for (int col = 0; col < source.Height; col++)
					{
						count[ip[0]]++;
						if (count[ip[0]] > max)
						{
							max = count[ip[0]];
						}
						ip += 3;
					}
					ip += offset;
				}
				source.UnlockBits(bdInput);
				for (int i = 0; i < 256; i++)
				{
					count[i] = (int)(count[i] * (histogram.Height - 1) * 1f / max * 1f);
				}
				bdInput = histogram.LockBits(new Rectangle(0, 0, histogram.Width, histogram.Height), ImageLockMode.ReadWrite, histogram.PixelFormat);
				ip = (byte*)bdInput.Scan0;
				offset = bdInput.Stride - histogram.Width * 3;
				for (int col = 0; col < histogram.Height; col++)
				{
					for (int row = 0; row < histogram.Width; row++)
					{
						byte value = 255;
						if (row <= (histogram.Height - count[col]))
						{
							value = 255;
						}
						else
						{
							value = 0;
						}

						ip[IndexOf(row, col, bdInput.Stride)] = value;
						ip[IndexOf(row, col, bdInput.Stride) + 1] = value;
						ip[IndexOf(row, col, bdInput.Stride) + 2] = value;
					}
				}
				histogram.UnlockBits(bdInput);
				return histogram;
			}
			else
			{
				return source;
			}


		}
		public int IndexOf(int row, int col, int stride)
		{
			return row * stride + col * 3;
		}
		/// <summary>
		/// Histogram Equalization
		/// </summary>
		/// <param name="source"></param>
		/// <returns></returns>
		unsafe
		public Bitmap HistrogramEqualization(Bitmap source)
		{
			if (source.PixelFormat == PixelFormat.Format24bppRgb)
			{
				BitmapData bdInputData = source.LockBits(new Rectangle(0, 0, source.Width, source.Height), ImageLockMode.ReadWrite, source.PixelFormat);
				byte* p = (byte*)bdInputData.Scan0;
				int total = source.Width * source.Height * 3;
				int offset = bdInputData.Stride - source.Width * 3;
				//Tinh tan so
				float[] frequency = new float[256];
				int[] count = new int[256];
				for (int row = 0; row < source.Width; row++)
				{
					for (int col = 0; col < source.Height; col++)
					{
						count[p[2]]++;
						p += 3;
					}
					p += offset;
				}
				for (int lev = 0; lev < 256; lev++)
				{
					frequency[lev] = count[lev] * 1.0f / total;
				}
				//Cumulative Distributive Function (CDF)
					float[] cdf = new float[256];
				cdf[0] = frequency[0];
				for (int lev = 1; lev < 256; lev++)
				{
					cdf[lev] = cdf[lev - 1] + frequency[lev];
				}
				//Multiple
				int[] newLev = new int[256];
				for (int lev = 0; lev < 256; lev++)
				{
					newLev[lev] = (int)(255 * cdf[lev]);
				}
				//Maping
				p = (byte*)bdInputData.Scan0;
				for (int row = 0; row < source.Width; row++)
				{
					for (int col = 0; col < source.Height; col++)
					{
						p[0] = p[1] = p[2] = (byte)newLev[p[2]];
						p += 3;
					}
					p += offset;
				}
				source.UnlockBits(bdInputData);
			}
			return source;
		}
		/// <summary>
		/// Histogram Specification
		/// </summary>
		/// <param name="source"></param>
		/// <param name="refer"></param>
		/// <returns></returns>
		public void HistogramSpecification(Bitmap source, Bitmap refer)
		{

		}
		/// <summary>
		/// radiobutton check
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void rbChecked(object sender, EventArgs e)
		{
			RadioButton rb = sender as RadioButton;
			if (rb.Checked)
			{
				Reset(2);
				switch (rb.Name)
				{
					case "rbHistoEqual":
						Bitmap bmOut = HistrogramEqualization(bInput);
						Bitmap hisOuput = CreateHistogram(bInput, true);
						pbOutput.Image = bmOut;
						pbHisOutput.Image = hisOuput;
						break;
					case "rbEndInSearch":
						
						break;
					case "rbHistoSpe":
						isHisSpe = true;
						pbHisInput.Image = Properties.Resources.templatepng;
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
						pbHisInput.Image.Dispose();
						pbHisInput.Image = pbInput.Image = null;
					}
					break;
				case 2:
					if (pbOutput.Image != null)
					{
						pbOutput.Image.Dispose();
						pbHisOutput.Image.Dispose();
						pbHisOutput.Image = pbOutput.Image = null;
					}
					break;
				case 0:
					Reset(1);
					Reset(2);
					break;
			}
		}
	}
}
