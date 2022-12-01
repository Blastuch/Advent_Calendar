using System;
using System.Linq;

public class FunkcjeAdventDay1
{

    public int CaloriesList()
    {

        List<string> allLinesText = File.ReadAllLines(@"C:\Users\szymo\Desktop\input.txt").ToList();
        int number = 0;
        List<int> calories = new List<int>();

        foreach (string i in allLinesText)
        {
            int j;

            if (i != "")
            {

                j = int.Parse(i);
                number += j;
            }
            else
            {
                calories.Add(number);
                number = 0;
            }

        }
        return calories.Max();
    }

    public int Top3CaloriesList()
    {

        List<string> allLinesText = File.ReadAllLines(@"C:\Users\szymo\Desktop\input.txt").ToList();
        int number = 0;
        List<int> calories = new List<int>();

        foreach (string i in allLinesText)
        {
            int j;

            if (i != "")
            {

                j = int.Parse(i);
                number += j;
            }
            else
            {
                calories.Add(number);
                number = 0;
            }

        }
        calories.Sort();
        int total = calories[calories.Count - 1] + calories[calories.Count -  2] + calories[calories.Count -  3];

        return total;
    }
}
