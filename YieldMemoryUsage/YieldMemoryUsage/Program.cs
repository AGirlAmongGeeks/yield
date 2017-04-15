using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YieldMemoryUsage
{
	class Program
	{
		static void Main(string[] args)
		{
			RandomNumbersExample.InitRandoms();

			var memoryAfterInit = GC.GetTotalMemory(false);
			Console.WriteLine(" --- Random Numbers Init --- ");
			Console.WriteLine(String.Format("Total Memory: \t\t\t\t{0,10}B", memoryAfterInit));
			Console.WriteLine();

			//Plain enumeration - withoud 'yield'.
			var numbersCount = 0;
			foreach (var numb in RandomNumbersExample.GetNumbersGt5())
			{
				numbersCount++;
			}
			var memoryAfterPlainEnumeration = GC.GetTotalMemory(false);
			Console.WriteLine(" --- After Plain Enumeration --- ");
			Console.WriteLine(String.Format("Total Memory: \t\t\t\t{0,10}B", memoryAfterPlainEnumeration));
			Console.WriteLine(String.Format("Enumeration memory usage: \t\t{0,10}B", (memoryAfterPlainEnumeration - memoryAfterInit).ToString()));
			Console.WriteLine();

			//Enumeration - with 'yield'.
			foreach (var numb in RandomNumbersExample.GetNumbersGt5WithYield())
			{
				numbersCount++;
			}
			var memoryAfterYieldEnumeration = GC.GetTotalMemory(false);
			Console.WriteLine(" --- After Yield Enumeration --- ");
			Console.WriteLine(String.Format("Total Memory: \t\t\t\t{0,10}B", memoryAfterYieldEnumeration));
			Console.WriteLine(String.Format("Enumeration memory usage: \t\t{0,10}B", (memoryAfterYieldEnumeration - memoryAfterPlainEnumeration).ToString()));

			Console.ReadLine();
		}
	}
}
