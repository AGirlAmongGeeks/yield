using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YieldMemoryUsage
{
	static class RandomNumbersExample
	{
		static List<double> RandomNumbers = new List<double>();

		public static void InitRandoms()
		{
			Random random = new Random();
			for (int i = 0; i < 10000000; i++)
			{
				RandomNumbers.Add(random.NextDouble() * 10);
			}
		}

		public static List<double> GetNumbersGt5()
		{
			var temp = new List<double>();
			foreach (var item in RandomNumbers)
			{
				if (item > 5)
				{
					temp.Add(item);
				}
			}
			return temp;
		}

		public static IEnumerable<double> GetNumbersGt5WithYield()
		{
			foreach (var item in RandomNumbers)
			{
				if (item > 5)
				{
					yield return item;
				}
			}
		}
	}
}
