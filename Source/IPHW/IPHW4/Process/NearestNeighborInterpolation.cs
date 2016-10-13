using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPHW4.Process
{
	public static class NearestNeighborInterpolation
	{
		public static Bitmap Scale(Bitmap bInput, float ratio)
		{
			int width = (int)(Math.Round(bInput.Width * ratio) + 0.5f);
			int height = (int)(Math.Round(bInput.Height * ratio) + 0.5f);
			Bitmap bOutput = new Bitmap(width,height);
			byte[,] source = GrayScale.ConvertTograyScale(bInput);

			for (int i = 0; i < bOutput.Width; i++)
			{
				for(int j = 0; j < bOutput.Height; j++)
				{
					byte color = (byte)source[(int)(Math.Floor(i / ratio) + 0.5f), (int)(Math.Floor(j / ratio) + 0.5f)];
					bOutput.SetPixel(i, j, Color.FromArgb(color, color, color));
				}
			}
			return bOutput;
		}
		public static Bitmap Rotate(Bitmap bInput, double degree)
		{
			Bitmap bOutput = new Bitmap(bInput.Width, bInput.Height);
			byte[,] source = GrayScale.ConvertTograyScale(bInput);
			for (int y_des = 0; y_des < bInput.Width; y_des++)
			{
				for (int x_des = 0; x_des < bInput.Height; x_des++)
				{

					int x_source = (int)(x_des * Math.Cos(degree) + (y_des - bInput.Height / 2) * Math.Sin(degree));
					int y_source = (int)(x_des * Math.Cos(degree) - (y_des - bInput.Height / 2) * Math.Sin(degree));
					byte color = (byte)(bInput.Height * bInput.Width);
					if (x_source < source.GetLength(0) && y_source < source.GetLength(0))
					{
						if (x_source < 0) x_source = 0;
						if (y_source < 0) y_source = 0;
						color = (byte)source[x_source, y_source];
					}
					bOutput.SetPixel(y_des, x_des, Color.FromArgb(color, color, color));
				}
			}
			
			return bOutput;
		}
	}
}
