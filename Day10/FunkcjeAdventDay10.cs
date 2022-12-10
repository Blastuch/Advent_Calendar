using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class FunkcjeAdventDay10
{
    public int Signal()
    {
        int signal = 1;
        int result = 0;
        int cycle = 0;

        foreach (string line in File.ReadLines(@"C:\Users\szymo\Desktop\InputDay10.txt")) 
        {
            if(line == "noop")
            {
                cycle++;
                if (cycle % 40 - 20 == 0)
                {
                    result += signal * cycle;
                }
            }
            else
            {
                string[] command = line.Split(' ');

                int amount = int.Parse(command[1]);

                for (int i = 0; i < 2; i++)
                {
                    cycle++;
                    if (cycle % 40 - 20 == 0)
                    {
                        result += signal * cycle;
                    }
                }

                signal += amount;
            }
            
        }
        return result;
    }



    public void Picture()
    {
        int signal = 1;
        int cycle = 0;
        int row = 0;

        char[,] picture = new char[7, 50];

        foreach (string line in File.ReadLines(@"C:\Users\szymo\Desktop\InputDay10.txt"))
        {

            
            if (line == "noop")
            {
                cycle++;
                if (cycle == 41)
                {
                    cycle = 1;
                    row++;
                }
                
                if (cycle == signal || cycle == signal + 1 || cycle == signal + 2)
                {
                    picture[row, cycle - 1] = '#';
                }
                else
                {
                    picture[row, cycle - 1] = '.';
                }
            }
            else
            {
                string[] command = line.Split(' ');

                int amount = int.Parse(command[1]);
                for (int i = 0; i < 2; i++)
                {
                    cycle++;
                    if (cycle == 41)
                    {
                        cycle = 1;
                        row++;
                    }
                    if (cycle == signal || cycle == signal + 1 || cycle == signal + 2)
                    {
                        picture[row, cycle - 1] = '#';
                    }
                    else
                    {
                        picture[row, cycle - 1] = '.';
                    }
                }

                signal += amount;

            }

            
        }
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 40; j++)
            {
                Console.Write(picture[i, j]);
            }
            Console.WriteLine();
        }
       
    }
}

