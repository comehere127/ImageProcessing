using IPHW6;
using IPHW6.Process;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPHW4
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
		//Sobel Edge Detector
		//x
		//1		0		-1
		//2		0		-2
		//1		0		-1
		//y
		//1		2		1
		//0		0		0
		//-1	-2		-1
		public static double[,] Convl3x3(double[,] image, string type)
		{
			double val;
			ConvolutionMatrix cm = new ConvolutionMatrix();
			if (type == "x")
			{
				//d(f)/d(x)
				cm.SetAll(0);
				cm.TopLeft = cm.BottomLeft = 1;
				cm.TopRight = cm.BottomRight = -1;
				cm.MidLeft = 2;
				cm.MidRight = -2;
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
										+ tmp[xTmp, yTmp - 1] * cm.MidLeft + tmp[xTmp, yTmp] * cm.Pixel + tmp[xTmp, yTmp] * cm.MidRight
										+ tmp[xTmp + 1, yTmp - 1] * cm.BottomLeft + tmp[xTmp + 1, yTmp] * cm.BottomMid + tmp[xTmp + 1, yTmp + 1] * cm.BottomRight;
					image[xTmp - 1, yTmp - 1] = val;
				}
			}

			//FileHandling.WriteFile(image);
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
		public static double[,] SobelConvol(double[,] imageX, double[,] imageY)
		{
			double[,] imageDes = new double[imageX.GetLength(0), imageX.GetLength(1)];
			for (int xDes = 0; xDes < imageX.GetLength(0); xDes++)
			{
				for (int yDes = 0; yDes < imageX.GetLength(1); yDes++)
				{
					imageDes[xDes, yDes] = Math.Sqrt(imageX[xDes, yDes] * imageX[xDes, yDes] + imageY[xDes, yDes] * imageY[xDes, yDes]);
				}
			}
			return imageDes;
		}
		public static double[,] Threshold(double[,] bSource, int iThreshold)
		{
			double val;
			for (int xDes = 0; xDes < bSource.GetLength(0); xDes++)
			{
				for (int yDes = 0; yDes < bSource.GetLength(1); yDes++)
				{
					val = bSource[xDes, yDes];
					if (val >= iThreshold)
						val = (double)0;
					else
						val = (double)255;
					bSource[xDes, yDes] = val;
				}
			}
			return bSource;
		}
	}
}
