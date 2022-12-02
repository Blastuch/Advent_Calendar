using System;
using System.Linq;
using System.IO;

public class FunkcjeAdventDay2
{
	public int RockPaperScissorsRank()
	{
		int score = 0;

		foreach(string line in File.ReadLines(@"C:\Users\szymo\Desktop\InputDay2.txt"))
        {
			if (line[0] == 'A')
			{
				if (line[2] == 'X')
				{
					score += 4;
				}
				else if (line[2] == 'Y')
				{
					score += 8;
				}
				else if (line[2] == 'Z')
				{
					score += 3;
				}
			}
			else if (line[0] == 'B')
			{
				if (line[2] == 'X')
				{
					score += 1;
				}
				else if (line[2] == 'Y')
				{
					score += 5;
				}
				else if (line[2] == 'Z')
				{
					score += 9;
				}
			}

			else if (line[0] == 'C')
			{
				if (line[2] == 'X')
				{
					score += 7;
				}
				else if (line[2] == 'Y')
				{
					score += 2;
				}
				else if (line[2] == 'Z')
				{
					score += 6;
				}
			}
		}
		return score;

	}
	public int RockPaperScissorsStrategy()
    {
		int score = 0;


		foreach (string line in File.ReadLines(@"C:\Users\szymo\Desktop\InputDay2.txt"))
		{
			if (line[0] == 'A')
			{
				if (line[2] == 'X')
				{
					score += 3;
				}
				else if (line[2] == 'Y')
				{
					score += 4;
				}
				else if (line[2] == 'Z')
				{
					score += 8;
				}
			}
			else if (line[0] == 'B')
			{
				if (line[2] == 'X')
				{
					score += 1;
				}
				else if (line[2] == 'Y')
				{
					score += 5;
				}
				else if (line[2] == 'Z')
				{
					score += 9;
				}
			}

			else if (line[0] == 'C')
			{
				if (line[2] == 'X')
				{
					score += 2;
				}
				else if (line[2] == 'Y')
				{
					score += 6;
				}
				else if (line[2] == 'Z')
				{
					score += 7;
				}
			}
		}



		return score;
    }
}
