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
		public static byte[,] ConvertTograyScale(Bitmap bInput)
		{
			byte[,] image = new byte[bInput.Width, bInput.Height];
			for (int i = 0; i < bInput.Width; i++)
			{
				for (int j = 0; j < bInput.Height; j++)
				{
					var c = bInput.GetPixel(i, j);
					byte gray = (byte)(0.299 * c.R + 0.587 * c.G + 0.114 * c.B);
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
		public static byte[,] Convl3x3(Bitmap bInput, string type)
		{
			int val;
			ConvolutionMatrix cm = new ConvolutionMatrix();
			byte[,] image = ConvertTograyScale(bInput);
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
			int[,] tmp = new int[tmpX, tmpY];
			for (int i = 0; i < tmpX; i++)
			{
				for (int j = 0; j < tmpY; j++)
				{
					if ((i - 1) >= 0 && (i + 1) < tmpX && (j - 1) >= 0 && (j + 1) < tmpY)
					{
						tmp[i, j] = (int)image[i - 1, j - 1];
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
					if (val < 0)
						val = 0;
					if (val > 255) val = 255;
					image[xTmp - 1, yTmp - 1] = (byte)val;
				}
			}

			//FileHandling.WriteFile(image);
			//for (int i = 0; i < image.GetLength(0); i++)
			//{
			//	Debug.WriteLine("");
			//	for (int j = 0; j < image.GetLength(1); j++)
			//	{
			//		Debug.Write(image[i, j] + "-");
			//	}
			//}
			return image;
		}

		public static Bitmap ConvertToBitmap(byte[,] bSource)
		{
			Bitmap bOutput = new Bitmap(bSource.GetLength(0), bSource.GetLength(1));
			byte val;
			for (int xDes = 0; xDes < bSource.GetLength(0); xDes++)
			{
				for (int yDes = 0; yDes < bSource.GetLength(1); yDes++)
				{
					val = bSource[xDes, yDes];
					bOutput.SetPixel(xDes, yDes, Color.FromArgb(val, val, val));
				}
			}
			return bOutput;
		}
		public static byte[,] SobelConvol(Bitmap bX, Bitmap bY)
		{
			int val;
			byte[,] imageX = ConvertBitmapToArrByte(bX);
			byte[,] imageY = ConvertBitmapToArrByte(bY);
			byte[,] imageDes = new byte[bX.Width, bX.Height];
			for (int xDes = 0; xDes < bX.Width; xDes++)
			{
				for (int yDes = 0; yDes < bX.Height; yDes++)
				{
					val = (int)Math.Sqrt(imageX[xDes, yDes] * imageX[xDes, yDes] + imageY[xDes, yDes] * imageY[xDes, yDes]);
					if (val < 0) val = 0;
					if (val > 255) val = 255;
					imageDes[xDes, yDes] = (byte)val;
				}
			}
			return imageDes;
		}
		public static byte[,] Threshold(Bitmap bInput, int iThreshold)
		{
			int val;
			byte color;
			byte[,] bSource = ConvertBitmapToArrByte(bInput);
			for (int xDes = 0; xDes < bSource.GetLength(0); xDes++)
			{
				for (int yDes = 0; yDes < bSource.GetLength(1); yDes++)
				{
					val = (int)bSource[xDes, yDes];
					if (val >= iThreshold)
						val = 0;
					else
						val = 255;

					color = (byte)val;
					bSource[xDes, yDes] = color;
				}
			}
			return bSource;
		}
		private static byte[,] ConvertBitmapToArrByte(Bitmap bInput)
		{
			byte[,] imageDes = new byte[bInput.Width, bInput.Height];
			for (int i = 0; i < bInput.Width; i++)
			{
				for (int j = 0; j < bInput.Height; j++)
				{
					imageDes[i, j] = bInput.GetPixel(i, j).B;
				}
			}
			return imageDes;
		}

	}
}
