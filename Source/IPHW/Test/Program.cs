using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(aaa(4, "x"));
			Console.ReadLine();
		}
		static int aaa(int k, string type)
		{
			int result=0;
			if (type == "x")
			{
				result = k + 1;
			}else if (type == "y")
			{
				result = k - 1;
			}

			if (type == "xy")
			{
				int val1 = aaa(4, "x");
				int val2 = aaa(4, "y");
				return val1 + val2;
			}
			else
				return result;
		}
	}
}
