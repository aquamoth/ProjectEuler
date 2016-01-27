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
			Problem8();

			Console.WriteLine("Press any key");
			Console.Read();
		}

		private static void Problem8()
		{
			var s = @"73167176531330624919225119674426574742355349194934
96983520312774506326239578318016984801869478851843
85861560789112949495459501737958331952853208805511
12540698747158523863050715693290963295227443043557
66896648950445244523161731856403098711121722383113
62229893423380308135336276614282806444486645238749
30358907296290491560440772390713810515859307960866
70172427121883998797908792274921901699720888093776
65727333001053367881220235421809751254540594752243
52584907711670556013604839586446706324415722155397
53697817977846174064955149290862569321978468622482
83972241375657056057490261407972968652414535100474
82166370484403199890008895243450658541227588666881
16427171479924442928230863465674813919123162824586
17866458359124566529476545682848912883142607690042
24219022671055626321111109370544217506941658960408
07198403850962455444362981230987879927244284909188
84580156166097919133875499200524063689912560717606
05886116467109405077541002256983155200055935729725
71636269561882670428252483600823257530420752963450".Replace("\r\n", "");
			var input = s.Select(x=>int.Parse(x.ToString())).ToArray();
			const int DIGITS = 13;
			var max = 0;
			for (var i = 0; i < input.Length - DIGITS; i++)
			{
				var product = input.Skip(i).Take(DIGITS).Aggregate(1, (x1, x2) => x1 * x2);
				if (product > max)
				{
					max = product;
					Console.WriteLine(s.Substring(i, DIGITS) + " = " + product);
				}
			}
			Console.WriteLine(max);
		}

		private static void Problem7()
		{
			var primes = new List<int>(new[] { 2 });

			for (var x = 3; primes.Count < 10001; x += 2)
			{
				if (!primes.Any(prime => x % prime == 0))
				{
					primes.Add(x);
					Console.WriteLine("#{0}: {1}", primes.Count, x);
				}
			}
		}

		private static void Problem6()
		{
			var sum = Math.Pow(Enumerable.Range(1, 100).Sum(), 2);
			var square = Enumerable.Range(1, 100).Select(x => Math.Pow(x, 2)).Sum();
			Console.WriteLine(sum - square);
		}

		private static void Problem4()
		{
			var max = 0;
			for (int a = 999; a >= 100; a--)
			{
				for (int b = 999; b >= 100; b--)
				{
					var value = a * b;
					var s=value.ToString();
					if (s== string.Join("", s.Reverse().ToArray()))
					{
						if (value > max)
						{
							max = value;
							Console.WriteLine(value);
							break;
						}
					}
				}
			}

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
