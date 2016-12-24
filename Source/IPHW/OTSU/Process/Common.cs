using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTSU.Process
{
	public class Common
	{
		public static double[,] ConvertTograyScale(Bitmap bInput)
		{
			double[,] image = new double[bInput.Width, bInput.Height];
			for (int i = 0; i < bInput.Width; i++)
			{
				for (int j = 0; j < bInput.Height; j++)
				{
					Color c = bInput.GetPixel(i, j);
					double gray = 0.299 * c.R + 0.587 * c.G + 0.114 * c.B;
					image[i, j] = gray;
				}
			}
			return image;
		}
		public static int[] GetHistogram(double[,] imageSource)
		{
			int[] arrHisto = new int[256];
			for(int i = 0; i < imageSource.GetLength(0); i++)
			{
				for(int j = 0; j < imageSource.GetLength(1); j++)
				{
					for(int k = 0; k < arrHisto.GetLength(0); k++)
					{
						if ((int)imageSource[i, j] == k)
						{
							arrHisto[k]++;
						}
					}
				}
			}

			return arrHisto;
		}
		private static double Px(int init,int end, int[] histo)
		{
			int sum = 0;
			for(int i = init; i <= end; i++)
			{
				sum += histo[i];
			}

			return (double)sum;
		}
		private static double Mx(int init, int end, int[] histo)
		{
			int sum = 0;
			int i;
			for (i = init; i <= end; i++)
			{
				sum += i * histo[i];
			}

			return (double)sum;
		}

		private static double FindMax(double[] vector, int n)
		{
			double maxVec = 0;
			int index = 0;

			for(int i = 1; i < n - 1; i++)
			{
				if (vector[i] > maxVec)
				{
					maxVec = vector[i];
					index = i;
				}
			}
			return index;
		}

		public static int GetOtsuThreshold(double[,] imageSource)
		{
			int[] hist = GetHistogram(imageSource);
			double[] vet = new double[256];
			byte target = 0;
			for(int i = 1; i != 255; i++)
			{
				double p1 = Px(0, i, hist);
				double p2 = Px(i + 1,255,hist);
				double p12 = p1 * p2;
				if (p12 == 0)
				{
					p12 = 1;
				}
				double diff = (Mx(0, i, hist) * p2) - (Mx(i + 1, 255, hist) * p1);
				vet[i] = (double)diff * diff / p12;
			}
			target = (byte)FindMax(vet, 256);
			return target;
		}
	}
}
