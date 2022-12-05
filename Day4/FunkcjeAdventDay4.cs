using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class FunkcjeAdventDay4
{
    public int RepeatedSections()
    {
        int result = 0;


        foreach (string line in File.ReadLines(@"C:\Users\szymo\Desktop\InputDay4.txt"))
        {
            string[] sections = line.Split(',','-');


            int firstSetStart = int.Parse(sections[0]);
            int firstSetEnd = int.Parse(sections[1]);
            int secondSetStart = int.Parse(sections[2]);
            int secondSetEnd = int.Parse(sections[3]);

            if ((firstSetStart >= secondSetStart && firstSetEnd <= secondSetEnd) || (secondSetStart >= firstSetStart && secondSetEnd <= firstSetEnd))
            {
                result++;
            }
        }
        return result;
    }

    public int OverlappingSections()
    {
        int result = 0;

        foreach (string line in File.ReadLines(@"C:\Users\szymo\Desktop\InputDay4.txt"))
        {
            string[] sections = line.Split(',', '-');

            int firstSetStart = int.Parse(sections[0]);
            int firstSetEnd = int.Parse(sections[1]);
            int secondSetStart = int.Parse(sections[2]);
            int secondSetEnd = int.Parse(sections[3]);


            if ( (firstSetEnd < secondSetStart || firstSetStart > secondSetEnd) == false)
            {
                result++;
            }
        }
        return result;
    }


}

