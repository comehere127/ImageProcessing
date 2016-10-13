using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPHW4.Process
{
	public static class BilinearInterpolation
	{
		public static Bitmap Scale(Bitmap bInput, float ratio)
		{
			int oWidth = (int)(bInput.Width * ratio);
			int oHeight = (int)(bInput.Height * ratio);
			Bitmap bOutput = new Bitmap(oWidth, oHeight, bInput.PixelFormat);
			byte[,] source = GrayScale.ConvertTograyScale(bInput);

			int xSrc, ySrc, A, B, C, D, newPoint;
			float alpha, beta;

			float raXDes = (float)(bInput.Width - 1) / oWidth;
			float raYDes = (float)(bInput.Height - 1) / oHeight;

			for (int xDes = 0; xDes < bOutput.Width; xDes++)
			{
				for (int yDes = 0; yDes < bOutput.Height; yDes++)
				{
					xSrc = (int)(xDes * raXDes);
					ySrc = (int)(yDes * raYDes);

					alpha = xDes * raXDes - xSrc;
					beta = yDes * raYDes - ySrc;

					A = source[xSrc, ySrc];
					B = source[xSrc + 1, ySrc];
					C = source[xSrc, ySrc + 1];
					D = source[xSrc + 1, ySrc + 1];
					//new = A(1-alpha)(1-beta) + B(alpha)(1-beta) + C(beta)(1-alpha) + D.alpha.beta
					newPoint = (int)(A * (1 - alpha) * (1 - beta) + B * alpha * (1 - beta) +
									C * beta * (1 - alpha) + D * alpha * beta);
					bOutput.SetPixel(xDes, yDes, Color.FromArgb(newPoint, newPoint, newPoint));
				}
			}
			return bOutput;
		}
		public static Bitmap Rotate(Bitmap bInput,double degree)
		{
			Bitmap bOutput = new Bitmap(bInput.Width, bInput.Height);
			byte[,] source = GrayScale.ConvertTograyScale(bInput);
			for (int xDes = 0; xDes < bInput.Width; xDes++)
			{
				for (int yDes = 0; yDes < bInput.Height; yDes++)
				{

					int xScr = (int)((yDes) * Math.Cos(degree) + (xDes - bInput.Width / 2) * Math.Sin(degree));
					int yScr = (int)((yDes) * Math.Cos(degree) - (xDes - bInput.Width / 2) * Math.Sin(degree));
					byte color = 0;
					if (xScr < source.GetLength(0) && yScr < source.GetLength(1))
					{
						if (xScr < 0 || yScr < 0)
							color = 0;
						else
						color = (byte)source[xScr, yScr];
					}
					bOutput.SetPixel(xDes, yDes, Color.FromArgb(color, color, color));
				}
			}
			Debug.WriteLine(source.GetLength(0) + "- " + source.GetLength(1));
			return bOutput;
		}
	}
}
