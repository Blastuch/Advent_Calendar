using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class FunkcjeAdventDay5
{
    public string CrateStacking()
    {
        string result = "";

        List<string> allLinesText = File.ReadAllLines(@"C:\Users\szymo\Desktop\InputDay5.txt").ToList(); //wczytanie do listy 

        int indexSpace = allLinesText.IndexOf(""); //znalezienie podzialu meidzy ruchami a ustawieniem pudelek


        // znalezienie ilosci stosow
        string[] stringOfPiles = allLinesText[indexSpace - 1].Split(" ");   
        int numberOfPiles = int.Parse(stringOfPiles[stringOfPiles.Length - 2]);

        List<char>[] piles = new List<char>[numberOfPiles]; //tablica list char na pudelka

        for(int i = 0; i < piles.Length; i++)
        {
            piles[i] = new List<char>();
        }

        //wypelnienie stosow/list pudelakmi
        for (int i = 0; i < numberOfPiles; i++)
        {
            int z = 0;
            for (int j = indexSpace - 2; j != -1; j--)
            {
                z = 1 + (i * 4);
                if (allLinesText[j][z] != ' ')
                {
                    piles[i].Add(allLinesText[j][z]);
                }
            }
        }
        
        for(int i = indexSpace + 1; i < allLinesText.Count; i++)
        {
            string[] command = allLinesText[i].Split(" ");   // odczytanie ruchow
            int moves = int.Parse(command[1]);
            int from = int.Parse(command[3]) - 1;
            int to = int.Parse(command[5]) - 1;

            for(int j = 0; j < moves; j++) // przeniesienie pudelek wedlug ruchow
            {
                
                    piles[to].Add(piles[from][piles[from].Count - 1]);
                    piles[from].RemoveAt(piles[from].Count - 1);
                
            }
        }

        //przeczytanie ostatnich pudelek
        foreach (List<char> i in piles)
        {
            result += i[i.Count - 1];
        }
        return result;
    }
    public string CratePilling()
    {
        string result = "";

        List<string> allLinesText = File.ReadAllLines(@"C:\Users\szymo\Desktop\InputDay5.txt").ToList(); //wczytanie do listy 

        int indexSpace = allLinesText.IndexOf(""); //znalezienie podzialu meidzy ruchami a ustawieniem pudelek


        // znalezienie ilosci stosow
        string[] stringOfPiles = allLinesText[indexSpace - 1].Split(" ");
        int numberOfPiles = int.Parse(stringOfPiles[stringOfPiles.Length - 2]);

        List<char>[] piles = new List<char>[numberOfPiles]; //tablica list char na pudelka

        for (int i = 0; i < piles.Length; i++)
        {
            piles[i] = new List<char>();
        }

        //wypelnienie stosow/list pudelakmi
        for (int i = 0; i < numberOfPiles; i++)
        {
            int z = 0;
            for (int j = indexSpace - 2; j != -1; j--)
            {
                z = 1 + (i * 4);
                
                if (allLinesText[j][z] != ' ')
                {
                    piles[i].Add(allLinesText[j][z]);
                }
            }
        }


        for (int i = indexSpace + 1; i < allLinesText.Count; i++)
        {

            string[] command = allLinesText[i].Split(" ");   // odczytanie ruchow
            int moves = int.Parse(command[1]);
            int from = int.Parse(command[3]) - 1;
            int to = int.Parse(command[5]) - 1;

            Stack<char> stos = new Stack<char>();

            for (int j = 0; j < moves; j++) // przeniesienie pudelek wedlug ruchow tym razem w stosie
            {
                stos.Push(piles[from][piles[from].Count - 1]);
                piles[from].RemoveAt(piles[from].Count - 1);
            }
            for (int j = 0; j < moves; j++)
            {
                piles[to].Add(stos.Pop());
                
            }
        }

        //przeczytanie ostatnich pudelek
        foreach (List<char> i in piles)
        {
            result += i[i.Count - 1];
        }
        return result;
    }
}

