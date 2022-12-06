using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class FunkcjeAdventDay6
{
    public int SignalStart(int noRepeatLength)
    {

        

        string signal = File.ReadAllText(@"C:\Users\szymo\Desktop\InputDay6.txt");

        Queue<char> letters = new Queue<char>();
        Queue<char> distinctLetters = new Queue<char>();

        for (int i = 0; i < signal.Length; i++)
        {
            letters.Enqueue(signal[i]);
            
            distinctLetters = new Queue<char>(letters.Distinct());
            if(distinctLetters.Count == letters.Count && letters.Count >= noRepeatLength)
            {
                return i + 1;
            }
            
            if (letters.Count >= noRepeatLength) 
            {
                letters.Dequeue();
            }

        }
        
        return 0;
    }
}

