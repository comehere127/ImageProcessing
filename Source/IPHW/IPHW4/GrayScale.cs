using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPHW4
{
	public static class GrayScale
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
	}
}
