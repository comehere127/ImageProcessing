using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPHW1s
{
	class Program
	{
		static void Main(string[] args)
		{
			double sigma = 1.0;
			double sum = 0.0;
			int N = 5;
			double[,] gKernel = new double[N, N];

			int index = N / 2;

			for (int x = -index; x <= index; x++)
			{
				for (int y = -index; y <= index; y++)
				{
					gKernel[x + index, y + index] = Gaussian(x, y, sigma);
					sum += gKernel[x + index, y + index];
				}
			}

			for (int i = 0; i < N; i++)
			{
				for (int j = 0; j < N; j++)
				{
					gKernel[i, j] = gKernel[i, j] / sum;
					Console.Write(gKernel[i, j] + " ");
				}
				Console.WriteLine();
			}



			Console.Read();
		}
		static double Gaussian(int x, int y, double sigma)
		{
			double c = 2 * sigma * sigma;
			return 1 / (Math.Exp((x * x + y * y) / c));
		}
	}
}
