using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1
{
	class Program
	{
		static void Main(string[] args)
		{
			//Problem1();
			//Problem2();
			Problem3();

			Console.WriteLine("Press any key");
			Console.Read();
		}

		private static void Problem3()
		{
			var result = 600851475143;
			for (int b = 3; result > b * b; b += 2)
			{
				while (result % b == 0)
				{
					result /= b;
					Console.WriteLine(b);
				}
			}
if(result>1)
{
	Console.WriteLine("Rest is: " + result);
}

			//var start=(long)result/2;
			//var end=(long)Math.Sqrt(result);
			//for (var x = start; x >= end; x -= 2)
			//{
			//	if (result % x == 0)
			//	{
			//		Console.WriteLine(x);
			//		break;
			//	}
			//}
		}

		private static void Problem2()
		{
			var sum = 0;
			var a = 1;
			var b = 2;
			while (b < 4000000)
			{
				if (b % 2 == 0) sum += b;
				//Console.WriteLine(b + " = " + " => " + sum);
				var x = a + b;
				a = b;
				b = x;
			}
			Console.WriteLine(sum);
		}

		private static void Problem1()
		{
			var result = Enumerable.Range(0, 1000).Where(x => x % 3 == 0 || x % 5 == 0).Sum();
			Console.WriteLine(result);
		}
	}
}
