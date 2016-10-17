using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPHW6
{
	public static class FileHandling
	{
		public static void WriteFile(byte[,] bSource)
		{
			StreamWriter sw = new StreamWriter(@"C:\Users\TuDHM\Desktop\output.txt");
			for (int i = 0; i < bSource.GetLength(0); i++)
			{
				for (int j = 0; j < bSource.GetLength(1); j++)
				{
					sw.Write(bSource[i, j] + "-");
				}
				sw.WriteLine();
			}

			sw.Close();
		}
	}
}
