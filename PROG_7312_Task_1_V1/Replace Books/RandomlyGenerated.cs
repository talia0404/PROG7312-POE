using System;
using System.Collections.Generic;

public static class RandomlyGenerated
{
	public static List<string> GenerateRandomDDSNumbers(int count)
	{
		Random randomNumbers = new Random();
		List<string> stringNumbers = new List<string>();

		while (stringNumbers.Count < count)
		{
			string callNumber = $"{randomNumbers.Next(0, 1000):000}.{randomNumbers.Next(0, 100):00} {GenerateRandomLetters(randomNumbers)}";

			if (!stringNumbers.Contains(callNumber))
			{
				stringNumbers.Add(callNumber);
			}

		}

		return stringNumbers;
	}

	private static string GenerateRandomLetters(Random randomL)
	{
		const string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
		char[] randomLetters = new char[3];

		for (int i = 0; i < 3; i++)
		{
			randomLetters[i] = letters[randomL.Next(letters.Length)];
		}

		return new string(randomLetters);
	}
}

