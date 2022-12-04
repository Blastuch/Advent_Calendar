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
            
            HashSet<int> firstSection = new HashSet<int>();
            HashSet<int> secondSection = new HashSet<int>();

            int firstSetStart = int.Parse(sections[0]);
            int firstSetEnd = int.Parse(sections[1]);
            int secondSetStart = int.Parse(sections[2]);
            int secondSetEnd = int.Parse(sections[3]);

            for(int i = firstSetStart; i<= firstSetEnd; i++)
            {
                firstSection.Add(i);
            }
            for(int i = secondSetStart; i<= secondSetEnd; i++)
            {
                secondSection.Add(i);
            }

            if(firstSection.IsSubsetOf(secondSection) || secondSection.IsSubsetOf(firstSection))
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

            HashSet<int> firstSection = new HashSet<int>();
            HashSet<int> secondSection = new HashSet<int>();

            int firstSetStart = int.Parse(sections[0]);
            int firstSetEnd = int.Parse(sections[1]);
            int secondSetStart = int.Parse(sections[2]);
            int secondSetEnd = int.Parse(sections[3]);

            for (int i = firstSetStart; i <= firstSetEnd; i++)
            {
                firstSection.Add(i);
            }
            for (int i = secondSetStart; i <= secondSetEnd; i++)
            {
                secondSection.Add(i);
            }
            if (firstSection.Overlaps(secondSection))
            {
                result++;
            }
        }
        return result;
    }


}

