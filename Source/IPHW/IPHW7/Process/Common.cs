using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPHW7.Process
{
	public static class Common
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
		public static Bitmap ConvertToBitmap(double[,] bSource)
		{
			Bitmap bOutput = new Bitmap(bSource.GetLength(0), bSource.GetLength(1));
			byte val;
			for (int xDes = 0; xDes < bSource.GetLength(0); xDes++)
			{
				for (int yDes = 0; yDes < bSource.GetLength(1); yDes++)
				{
					val = (byte)bSource[xDes, yDes];
					bOutput.SetPixel(xDes, yDes, Color.FromArgb(val, val, val));
				}
			}
			return bOutput;
		}
		public static double[,] ComputeAtPixel(double[,] image, double k, double sigma)
		{
			double[,] X = Conv3x3(image, "x");
			double[,] Y = Conv3x3(image, "y");
			//double[,] XY = Conv3x3(image, "xy");

			double[,] DesImage = new double[image.GetLength(0), image.GetLength(1)];

			for (int xDes = 0; xDes < image.GetLength(0); xDes++)
			{
				for (int yDes = 0; yDes < image.GetLength(1); yDes++)
				{
					double Gauss = Gaussian(xDes, yDes, sigma);
					double A = Gauss * Math.Pow(X[xDes, yDes], 2);
					double B = Gauss * Math.Pow(Y[xDes, yDes], 2);
					double C = Gauss * X[xDes, yDes] * Y[xDes, yDes];

					double Det = A * B - Math.Pow(C,2);
					double Trace = A + B;

					DesImage[xDes, yDes] = Det - k * Math.Pow(Trace, 2);
				}
			}

			return DesImage;
		}
		public static double[,] Thresholding(double[,] image,double Threshold)
		{
			double[,] DesImage = new double[image.GetLength(0), image.GetLength(1)];
			for (int xDes = 0; xDes < image.GetLength(0); xDes++)
			{
				for (int yDes = 0; yDes < image.GetLength(1); yDes++)
				{
					if (image[xDes, yDes] >= Threshold)
						DesImage[xDes, yDes] = 255;
					else
						DesImage[xDes, yDes] = 0;
				}
			}
			return DesImage;
		}
		public static double[,] Conv3x3(double[,] image, string type)
		{
			double val;
			double[,] DesImage = new double[image.GetLength(0), image.GetLength(1)];
			ConvolutionMatrix cm = new ConvolutionMatrix();
			if (type == "x")
			{
				//d(f)/d(x)
				cm.SetAll(0);
				cm.TopLeft = cm.BottomLeft = -1;
				cm.TopRight = cm.BottomRight = 1;
				cm.MidLeft = -2;
				cm.MidRight = 2;
			}
			else if (type == "y")
			{
				//d(f)/d(y)
				cm.SetAll(0);
				cm.TopLeft = cm.TopRight = 1;
				cm.BottomLeft = cm.BottomRight = -1;
				cm.TopMid = 2;
				cm.BottomMid = -2;
			}

			//Convolution
			int tmpX = image.GetLength(0) + 2;
			int tmpY = image.GetLength(1) + 2;
			double[,] tmp = new double[tmpX, tmpY];
			for (int i = 0; i < tmpX; i++)
			{
				for (int j = 0; j < tmpY; j++)
				{
					if ((i - 1) >= 0 && (i + 1) < tmpX && (j - 1) >= 0 && (j + 1) < tmpY)
					{
						tmp[i, j] = image[i - 1, j - 1];
					}
					else
					{
						tmp[i, j] = 0;
					}
				}
			}

			for (int xTmp = 1; xTmp < tmp.GetLength(0) - 1; xTmp++)
			{
				for (int yTmp = 1; yTmp < tmp.GetLength(1) - 1; yTmp++)
				{
					val = tmp[xTmp - 1, yTmp - 1] * cm.TopLeft + tmp[xTmp - 1, yTmp] * cm.TopMid + tmp[xTmp - 1, yTmp + 1] * cm.TopRight
							+ tmp[xTmp, yTmp - 1] * cm.MidLeft + tmp[xTmp, yTmp] * cm.Pixel + tmp[xTmp, yTmp + 1] * cm.MidRight
							+ tmp[xTmp + 1, yTmp - 1] * cm.BottomLeft + tmp[xTmp + 1, yTmp] * cm.BottomMid + tmp[xTmp + 1, yTmp + 1] * cm.BottomRight;
					DesImage[xTmp - 1, yTmp - 1] = val;
				}
			}

			//if(type == "xy")
			//{
			//	double[,] X = Conv3x3(image, "x");
			//	double[,] Y = Conv3x3(image, "y");
			//	double[,] XY = new double[X.GetLength(0), X.GetLength(1)];

			//	for (int xDes = 0; xDes < X.GetLength(0); xDes++)
			//	{
			//		for (int yDes = 0; yDes < X.GetLength(1); yDes++)
			//		{
			//			XY[xDes, yDes] = X[xDes, yDes] * Y[xDes, yDes];
			//		}
			//	}
			//}

			//FileHandling.WriteFile(image);
			return DesImage;
		}
		public static double Gaussian(int x, int y, double sigma)
		{
			double c = 2 * sigma * sigma;
			return 1 / (Math.Exp((Math.Pow(x, 2) + Math.Pow(y, 2))/c));
		}
	}
}
