using IPHW6.Process;
using System;
using System.Collections.Generic;
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
			Bitmap bOutput = new Bitmap(bInput.Width, bInput.Height);
			Bitmap bImage;
			byte[,] image;
			int val;
			bImage = (Bitmap) bOutput.Clone();
			image = ConvertTograyScale(bInput);
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
			else if(type=="y")
			{
				//d(f)/d(y)
				cm.SetAll(0);
				cm.TopLeft = cm.TopRight = 1;
				cm.BottomLeft = cm.BottomRight = -1;
				cm.TopMid = 2;
				cm.BottomMid = -2;
			}

			if (type == "xy")
			{
				
				byte[,] imageX = Convl3x3(bInput, "x");
				byte[,] imageY = Convl3x3(bInput, "y");
				byte[,] imageDes = imageX;
				for (int xDes = 0; xDes < imageX.GetLength(0); xDes++)
				{
					for (int yDes = 0; yDes < imageX.GetLength(1); yDes++)
					{
						val = (int) Math.Sqrt(imageX[xDes, yDes] * imageX[xDes, yDes] + imageY[xDes, yDes] * imageY[xDes, yDes]);
						if (val > 255)
							val = 255;
						imageDes[xDes, yDes] = (byte)val;
					}
				}
				return imageDes;
			}
			else
				return image;
		}

		private static void ConvertToBitmap(Bitmap bOutput, byte[,] bSource)
		{
			byte val;
			for (int xDes = 0; xDes < bSource.GetLength(0); xDes++)
			{
				for (int yDes = 0; yDes < bSource.GetLength(1); yDes++)
				{
					val = bSource[xDes, yDes];
					bOutput.SetPixel(xDes, yDes, Color.FromArgb(val, val, val));
				}
			}
		}
		public static byte[,] Threshold(byte[,] bSource, int iThreshold)
		{
			int val;
			byte color;
			for (int xDes = 0; xDes < bSource.GetLength(0); xDes++)
			{
				for (int yDes = 0; yDes < bSource.GetLength(1); yDes++)
				{
					val = (int)bSource[xDes, yDes];
					if (val < iThreshold)
						val = iThreshold;

					color = (byte)val;
					bSource[xDes, yDes] = color;
				}
			}
			return bSource;
		}

	}
}
