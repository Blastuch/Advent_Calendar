using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


internal class FunkcjeAdventDay11
{
    public int MonkeyBusiness()
    {

        List<Monkey> monkeys = new List<Monkey>();

        List<int> monkeyActivityList = new List<int>();

        int numberOfRounds = 20;

        int monkeyNumber = 0;
        
        int worryLevel = 0;

        foreach (string line in File.ReadLines(@"C:\Users\szymo\Desktop\InputDay11.txt"))
        {
            string lineT = line;

            if (line == "")
                continue;

            if (line[0] == ' ')
            {
                lineT = line.Trim();
            }

            string[] command = lineT.Split(' ', ',');

            if (command[0] == "Monkey")
                monkeys.Add(new Monkey());

            if(command[0] == "Starting")
            {

                for (int i = 2; i < command.Length; i++)
                    {
                    if (command[i] != "")
                    {
                        
                        monkeys.Last().items.Enqueue(int.Parse(command[i]));
                    }
                    }
                    
            }
            if(command[0] == "Operation:")
            {
                monkeys.Last().operationSign = command[4];
                monkeys.Last().operationValue = command[5];
            }

            if (command[0] == "Test:")
            {
                monkeys.Last().testValue = int.Parse(command[3]);
            }
            if (command[1] == "true:")
            {
                monkeys.Last().trueThrow = int.Parse(command[5]);
            }
            if (command[1] == "false:")
            {
                monkeys.Last().falseThrow = int.Parse(command[5]);
            }

            

            monkeyNumber++;
        }

        for (int i = 0; i < numberOfRounds; i++) 
        {
            foreach(Monkey m in monkeys)
            {
                int countOfItems = m.items.Count();

                for(int j = 0; j < countOfItems; j++)
                {
                    m.monkeyActivity++;
                    int dequeuedItem = m.items.Dequeue();

                    if(m.operationValue == "old")
                    {
                        if(m.operationSign == "+")
                        {
                            worryLevel = dequeuedItem * 2 / 3;
                        }
                        else if ( m.operationSign == "*")
                        {
                            worryLevel = dequeuedItem * dequeuedItem / 3;
                        }
                    }
                    else
                    {
                        if (m.operationSign == "+")
                        {
                            worryLevel = (dequeuedItem + int.Parse(m.operationValue))/3;
                        }
                        else if(m.operationSign == "*")
                        {
                            worryLevel = ((dequeuedItem * int.Parse(m.operationValue))/3);
                           
                            
                        }

                    }

                    if (worryLevel % m.testValue == 0)
                    {
                        monkeys[m.trueThrow].items.Enqueue(worryLevel);
                    }
                    else
                        monkeys[m.falseThrow].items.Enqueue(worryLevel);


                }


            }



        }
        foreach(Monkey m in monkeys)
        {
            monkeyActivityList.Add(m.monkeyActivity);
        }
        monkeyActivityList.Sort();
        return monkeyActivityList[monkeyActivityList.Count - 1] * monkeyActivityList[monkeyActivityList.Count - 2];
        
    }
}

