using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class FunkcjeAdventDay8
{
    public int VisibleTrees()
    {
        int result = 0;



        int lines = File.ReadAllLines(@"C:\Users\szymo\Desktop\InputDay8.txt").Length;
        int length = File.ReadLines(@"C:\Users\szymo\Desktop\InputDay8.txt").First().Length;
        int[,] trees = new int[lines, length];
        int[,] resultArray = new int[lines, length];

        int z = 0;
        

        int visible = 0;

        foreach (string line in File.ReadLines(@"C:\Users\szymo\Desktop\InputDay8.txt"))
        {
            for (int i = 0; i < length; i++)
                trees[z, i] = (int)(line[i] - '0');
            z++;
        }

        for (int i = 0; i < trees.GetLength(0) -1; i++)
        {
            for (int j = 0; j < trees.GetLength(1) - 1; j++)
            {
                visible = 0;
                for(int k = 0; k < i; k++)
                {
                    
                    if (trees[i,j] <= trees[k,j])
                    {
                        
                        
                        visible += 1;
                        
                        
                        break;
                    }
                }
                for (int k = 0; k < j; k++)
                {
                    
                    if (trees[i, j] <= trees[i,k])
                    {
                        
                        visible += 1;
                        
                        break;
                    }
                    
                }
                for (int k = length; k-1 > i; k--)
                {
                    
                    if (trees[i, j] <= trees[k-1, j])
                    {
                        
                        visible += 1;
                        
                        break;
                    }
                }
                for (int k = lines; k-1 > j; k--)
                {

                    if (trees[i, j] <= trees[i, k - 1])
                    {
                        visible += 1;
                        
                        break;
                    }
                }
                if(visible == 4)
                { resultArray[i, j] = 1; }
            }
                    
        }
        for (int i = 0; i < trees.GetLength(0); i++)
        {
            for (int j = 0; j < trees.GetLength(1); j++)
            {
                if (resultArray[i, j] == 0)
                    result++;
            }
            
        }
        return result;
    }

    public int ViewFromTreeHouse()
    {
        int result = 0;

        int lines = File.ReadAllLines(@"C:\Users\szymo\Desktop\InputDay8.txt").Length;
        int length = File.ReadLines(@"C:\Users\szymo\Desktop\InputDay8.txt").First().Length;

        int[,] trees = new int[lines, length];

        int z = 0;

        foreach (string line in File.ReadLines(@"C:\Users\szymo\Desktop\InputDay8.txt"))
        {
            for (int i = 0; i < length; i++)
                trees[z, i] = (int)(line[i] - '0');
            z++;
        }

        for (int i = 0; i < trees.GetLength(0) - 1; i++)
        {
            for (int j = 0; j < trees.GetLength(1) - 1; j++)
            {
                int leftTrees = 0;
                int rightTrees = 0;
                int topTrees = 0;
                int bottomTrees = 0;


                for (int k = i - 1; k >= 0; k--) // from middle to top
                {
                    topTrees++;
                    if (trees[i,j] <= trees[k,j])
                    {
                        break;
                    }
                    
                }

                for (int k = j - 1; k >= 0; k--) // from middle to left
                {
                    leftTrees++;
                    if (trees[i, j] <= trees[i, k])
                    {
                        break;
                    }
                    
                }

                for (int k = j + 1; k <= length -1; k++) // from middle to right
                {
                    rightTrees++;
                    if (trees[i, j] <= trees[i, k])
                    {
                        break;
                    }
                    
                }

                for (int k = i + 1; k <= lines -1; k++) // from middle to bottom
                {
                    bottomTrees++;
                    if (trees[i, j] <= trees[k, j])
                    {
                        break;
                    }
                    
                }

                int currentValue = leftTrees * topTrees * rightTrees * bottomTrees;

                if (currentValue > result)
                {
                    result = currentValue;
                }
            }
        }
        return result;
    }
}

