using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class FunkcjeAdventDay9
{/*
    public int PositionsCovered()  // nie dziala na razie
    {

        ///////////////jak dystans sie zwiekszy o 1 to wtedy zaznaczyc pporzednie pole

        int[,] space = new int[100, 100];

        int headX = 4;
        int headY = 0;
        int tailX = 4;
        int tailY = 0;
        int diffX = 0;
        int diffY = 0;

        space[4, 0] = 1;

        
        foreach(string line in File.ReadLines(@"C:\Users\szymo\Desktop\TestInputDay9.txt"))
        {
            Console.WriteLine(line);
            string[] move = line.Split(' ');

            if (move[0] == "U")                    //Up
            {
                headX -= int.Parse(move[1]);
            }
            else if (move[0] == "R")              //Right
            {
                headY += int.Parse(move[1]);
            }
            else if (move[0] == "D")              //Down
            {
                headX += int.Parse(move[1]);
            }
            else                                  //Left
            {
                headY -= int.Parse(move[1]);
            }
            Console.WriteLine("xh " + headX + "yh " + headY);
            Console.WriteLine("xt " + tailX + "yt " + tailY);

            diffX = headX - tailX;
            diffY = headY - tailY;

            Console.WriteLine("diffx " + diffX + " diffy " + diffY);

            for (int i = int.Parse(move[1]); i > 0; i--)
            {
                if(diffX > )




                if (diffX < -1)    // 
                {
                    tailX -= 1;
                }
                if (diffX > 1)
                {
                    tailX += 1;
                }
                if (diffY > 1)
                {
                    tailY += 1;
                }
                if (diffY < -1)
                {
                    tailY -= 1;
                }
                //if (tailX >= 0 && tailX <= 4 && tailY >= 0 && tailY <= 4)
                //{
                if(tailX == headX && tailY == headY)
                {
                    Console.WriteLine("bumped into head");
                    diffX = 0;
                    diffY = 0;
                    continue;
                }
                    space[tailX, tailY] = 1;
                //}
                //else
                //{
                    //Console.WriteLine("za duze za amle");
                //}
                for (int z = 0; z < 5; z++) // tabelka z ruchem
                {
                    for (int j = 0; j < 6; j++)
                    {
                        space[headX, headY] = 5;
                        space[tailX, tailY] = 4;
                        Console.Write(space[z, j]);
                        
                    }
                    Console.WriteLine( "  ");
                }
                Console.WriteLine();

                
            }
            

            

            Console.WriteLine("x " + tailX + " " + tailY);
            diffX = 0;
                diffY = 0;
        }
       
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                    Console.Write(space[i, j]);
            }
            Console.WriteLine();
        }
         

        //Console.WriteLine(space[1, 1]);






        return headX;
    }
    */
    public int Funkcja()
    {

        int headX = 4;
        int headY = 0;
        int tailX = 4;
        int tailY = 0;
        int previousHeadX = 0;
        int previousHeadY = 0;



        List<string> visited = new List<string>();

        visited.Add("4 0");

        foreach (string line in File.ReadLines(@"C:\Users\szymo\Desktop\InputDay9.txt"))
        {
           
            string[] move = line.Split(' ');

            string direction = move[0];
            int speed = int.Parse(move[1]);




            for (int i = 0; i < speed; i++)
            {
                previousHeadX = headX;
                previousHeadY = headY;

                if (direction == "U")                    //Up
                {
                    
                    headX--;
                    
                }
                else if (direction == "R")                //Right
                {
                    
                    headY++;
                    
                }
                else if (direction == "D")                //Down
                {
                    
                    headX++;
                    
                }
                else if (direction == "L")                //Left
                {
                    
                    headY--;
                    
                }

                if(Math.Abs(headX - tailX) > 1.5 || Math.Abs(headY - tailY) > 1.5) 
                {
                    
                    visited.Add(previousHeadX.ToString() + " " + previousHeadY.ToString());

                    tailX = previousHeadX;
                    tailY = previousHeadY;
                }

                
                
            }

            
            
        }
        foreach (string z in visited)
            Console.WriteLine(z);


        Console.WriteLine(visited.Distinct().Count());
        return 0;



    }

    /* Nie dziala na razie
    public int Funkcja2()
    {
        int headX = 4;
        int headY = 0;
        int tailX = 4;
        int tailY = 0;
        int previousTailX = 0;
        int previousTailY = 0;
        int fakeHeadX = 0;
        int fakeHeadY = 0;



        int[,] tailPositions = new int[2, 10];

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                if (i == 0)
                    tailPositions[i, j] = 4;
                else
                    tailPositions[i, j] = 0;
            }       
        }

        int[,] previousTailPositions = new int[2, 10];
        
        int[,] testTailPositions = new int[10, 10];


        List<string> visited = new List<string>();

        visited.Add("4 0");

        foreach (string line in File.ReadLines(@"C:\Users\szymo\Desktop\TestInputDay9.txt"))
        {

            string[] move = line.Split(' ');

            string direction = move[0];
            int speed = int.Parse(move[1]);


            previousTailPositions = tailPositions;


            for (int i = 0; i < speed; i++)
            {
                Console.WriteLine(" next move of 1");
                if (direction == "U")                    //Up
                {

                    headX--;

                }
                else if (direction == "R")                //Right
                {

                    headY++;

                }
                else if (direction == "D")                //Down
                {

                    headX++;

                }
                else if (direction == "L")                //Left
                {

                    headY--;

                }

                tailPositions[0, 0] = headX;                    ///// Head is assinged as a start of rope
                tailPositions[1, 0] = headY;

                for (int j = 1; j < 9; j++)                     // For every part check if previous part is too far
                {

                    if (Math.Abs(tailPositions[0, j - 1] - tailPositions[0, j]) > 1.5 || Math.Abs(tailPositions[1, j - 1] - tailPositions[1, j]) > 1.5) /// For every part check if previous part is too far
                    {
                        // if its too far move it in previous position of now chased part
                        tailPositions[0, j] = previousTailPositions[0, j - 1];
                        tailPositions[1, j] = previousTailPositions[1, j - 1];
                        //if (j == 8)
                        //{
                        //   visited.Add(tailPositions[0, j].ToString() + " " + tailPositions[1, j].ToString());
                        //  Console.WriteLine(line + "  " + i + " speed");
                        //   Console.WriteLine(" This happaned when J was 8 and x " + tailPositions[0, j] + " " + tailPositions[0, j - 1] + "  on x  and " + tailPositions[1, j] + " y " + tailPositions[1, j - 1] + " on y");
                        //}

                    }
                    else
                    {
                        Console.WriteLine(" not enough difference " + tailPositions[0, j] + " " + tailPositions[0, j - 1] + "  on x  and " + tailPositions[1, j] + "  " + tailPositions[1, j - 1] + " on y");
                        continue;
                    }


                    testTailPositions[tailPositions[0,j], tailPositions[1,j]] = j;
                }

                for (int k = 0; k < 10; k++)
                {
                    for (int u = 0; u < 10; u++)
                    {
                        Console.Write(testTailPositions[k, u]);
                    }
                    Console.WriteLine();
                }

                foreach (string s in visited)
                    Console.WriteLine(s);
            }



        }
        foreach (string z in visited)
            Console.WriteLine(z);


        Console.WriteLine(visited.Distinct().Count());
        return 0;
    }
    */
}

