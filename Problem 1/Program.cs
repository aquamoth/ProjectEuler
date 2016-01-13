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
			Problem1();

			//Problem2();


			Console.WriteLine("Press any key");
			Console.Read();
		}

		private static void Problem1()
		{
			var result = Enumerable.Range(0, 1000).Where(x => x % 3 == 0 || x % 5 == 0).Sum();
			Console.WriteLine(result);
		}
	}
}
