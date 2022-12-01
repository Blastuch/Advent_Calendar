using System;
using System.Linq;

public class FunkcjeAdventDay1v2
{

    public int CaloriesList()
    {

        List<string> allLinesText = File.ReadAllLines(@"C:\Users\szymo\Desktop\input.txt").ToList();
        int number = 0;
        int highestValue = 0;

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
                if (number > highestValue)
                {
                    highestValue = number;
                }
                number = 0;
            }

        }
        return highestValue;
    }

    public int Top3CaloriesList()
    {
        int first = 0;
        int second = 0;
        int third = 0;

        List<string> allLinesText = File.ReadAllLines(@"C:\Users\szymo\Desktop\input.txt").ToList();
        int number = 0;
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
                if(number > first)
                {
                    third = second;
                    second = first;
                    first = number;
                }
                else if(number > second)
                {
                    third = second;
                    second = number;
                }
                else if(number > third)
                {
                    third = number;
                }
                number = 0;
            }

        }
        int total = first + second + third;
        return total;
    }
}
