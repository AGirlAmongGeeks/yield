using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YieldExample
{
	static class AnimalExample
	{
		static IEnumerable<string> Animals = new List<string>()
		{
			"dog", "cat", "bird", "bee", "donkey", "horse", "cow", "monkey", "snake", "turtle"
		};

		public static List<string> GetAnimalsWith3LetterName()
		{
			List<string> temp = new List<string>();
			foreach (var data in Animals)
			{
				if (data.Length == 3)
				{
					temp.Add(data);
				}
			}
			return temp;
		}

		public static IEnumerable<string> GetAnimalsWith3LetterNameWithYield()
		{
			foreach (var data in Animals)
			{
				if (data.Length == 3)
				{
					yield return data;
				}
			}

			yield return "AnimalFromOutsideTheList";
		}
	}
}
