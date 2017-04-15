using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YieldExample
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine(" -- With 'Yield' Example -- ");
			foreach (var animalYield in AnimalExample.GetAnimalsWith3LetterNameWithYield())
			{
				Console.WriteLine(animalYield);
			}

			Console.WriteLine();
			Console.WriteLine(" -- Without 'Yield' Example -- ");
			foreach (var animal in AnimalExample.GetAnimalsWith3LetterName())
			{
				Console.WriteLine(animal);
			}

			Console.ReadLine();
		}
	}
}
