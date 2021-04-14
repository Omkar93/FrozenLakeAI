using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrozenLakeAIProblem
{
    public class CreateMatrix
    {
        public static String[,] Construct(int AgentVerticalIndex=0, int AgentHorizantalIndex=0)
        {
            Console.WriteLine("Creating an 10*10  frozen lake matrix \n \n \n");
            String[,] matrix = new String[11, 11];
            matrix[10, 10] = Element.Target.ToString();
            if(AgentVerticalIndex ==0)
            {
                if(AgentHorizantalIndex==0)
                    matrix[10, 1] = Element.Agent.ToString();

            }
            else
                matrix[AgentVerticalIndex, AgentHorizantalIndex] = Element.Agent.ToString();


            matrix[10, 3] = Element.Key.ToString();
            matrix[5, 2] = Element.Key.ToString();
            matrix[3, 4] = Element.Key.ToString();
            matrix[6, 4] = Element.Key.ToString();
            matrix[4, 8] = Element.Key.ToString();
            matrix[9, 8] = Element.Key.ToString();
            matrix[2, 9] = Element.Key.ToString();


            Construct(ref matrix);

            return matrix;
            
        }

        public static void Construct(ref String[,] matrix)
        {
            Console.BackgroundColor = ConsoleColor.White;
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    if (matrix[i, j] == Element.Agent.ToString())
                        Console.ForegroundColor = ConsoleColor.Green;
                    else if (matrix[i, j] == Element.Target.ToString())
                        Console.ForegroundColor = ConsoleColor.Red;
                    else if (matrix[i, j] == Element.Key.ToString())
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                    else
                        Console.ResetColor();
                    try
                    {

                        Console.Write(matrix[i, j].ToString() + " ");
                    }
                    catch
                    {

                        Console.Write("Null" + " ");
                    }

                }
                Console.WriteLine();
            }

        }      
    }
}
