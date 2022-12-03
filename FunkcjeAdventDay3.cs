using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FunkcjeAdventDay3
{
    public int BackpackPriority()
        {
        int result = 0;
        bool appeared;

        foreach (string line in File.ReadLines(@"C:\Users\szymo\Desktop\InputDay3.txt"))
        {
            appeared = false;
            for (int i = 0; i < line.Length / 2; i++)
            {
                
                for (int j = line.Length / 2; j < line.Length; j++)
                {                    
                   
                                         
                    if (line[i] == line[j])
                    {
                        if (line[i] < 97)
                        {
                            
                            result += (line[i] - 38);
                        }
                        else
                        {
                            
                            result += (line[i] - 96);
                        }
                        appeared = true;                      
                        
                    }
                    if (appeared == true)
                    { break; }

                }
                if (appeared == true)
                { break; }

            }
        }
        return result;
        }

    public int BackpackBadge()
    {
        int result = 0;
        int elfNumber = 3;
        List<string> elfGroup = new List<string>();

        foreach (string line in File.ReadLines(@"C:\Users\szymo\Desktop\InputDay3.txt"))
        {            
            elfGroup.Add(line);
           
            if (elfGroup.Count == elfNumber)
            {
                string firstElf = elfGroup[0];
                for (int i = 0; i < firstElf.Length; i++)
                {
                    if(elfGroup[1].Contains(firstElf[i]))
                    {
                        if (elfGroup[2].Contains(firstElf[i]))
                        {
                            if (firstElf[i] < 97)
                            {

                                result += (firstElf[i] - 38);
                                break;
                            }
                            else
                            {

                                result += (firstElf[i] - 96);
                                break;
                            }
                        }
                    }                    
                }                
                elfGroup.Clear();
            }
        }
        return result;
    }
}

