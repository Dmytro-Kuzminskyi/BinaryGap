using System;

namespace BinaryGap
{
	class Program
	{
		static void Main(string[] args)
		{
			Solution s = new Solution();
			Console.Write("Enter N: ");
			int N = int.Parse(Console.ReadLine());
			Console.WriteLine("A binary gap of {0}", s.solution(N));
			Console.ReadKey();
		}
	}
}
