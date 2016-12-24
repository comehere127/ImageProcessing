using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPHW7.Process
{
	public class ConvolutionMatrix
	{
		public int TopLeft = 0,		TopMid = 0,		TopRight = 0;
		public int MidLeft = 0,		Pixel = 0,		MidRight = 0;
		public int BottomLeft = 0,	BottomMid = 0,	BottomRight = 0;

		public void SetAll(int iVal)
		{
			TopLeft = TopMid = TopRight = MidLeft = Pixel = MidRight = BottomLeft = BottomMid = BottomRight = iVal;
		}
	}
}
