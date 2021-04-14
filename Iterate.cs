using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrozenLakeAIProblem
{
    public class Iterate
    {
        static bool success = false;
        public static int stepsPerformed = 0;

        public static void Compute(ref String[,] matrix)
        {
            int AgentVeritcalIndex = GetAgentIndex(matrix).Item1;
            int AgentHorizantalIndex = GetAgentIndex(matrix).Item2;

            int TargetVerticalIndex = GetTargetIndex(matrix).Item1;
            int TargetHorizantalIndex = GetTargetIndex(matrix).Item1;
            int xCounter = 0;
            int yCounter = 0;

            for (int i = AgentVeritcalIndex; i <= 11; i++)
            {
                for (int j = AgentHorizantalIndex; j <= 10; j++)
                {
                    if (success)
                        break;
                    if ((i == AgentVeritcalIndex) && (j == AgentHorizantalIndex))
                        continue;
                    if (matrix[i, j] == Element.Key.ToString())
                    {
                        //if i = 10, reduce i and check , if good then move, 
                        if (i == 10)
                        {
                            if (matrix[i - 1, j-1] != Element.Key.ToString())
                            {
                                matrix[AgentVeritcalIndex, AgentHorizantalIndex] = "Null";
                                matrix[i-1, j-1] = Element.Agent.ToString();
                                Console.WriteLine("\n \n Next Iteration");

                                CreateMatrix.Construct(ref matrix);
                                stepsPerformed++;
                                if ((GetAgentIndex(matrix).Item1 == TargetVerticalIndex) && (GetAgentIndex(matrix).Item2 == TargetHorizantalIndex))
                                {
                                    Console.WriteLine("Agent Reached to Destination");
                                    success = true;


                                    break;

                                }
                                else
                                {
                                    Compute(ref matrix);

                                }
                            }
                        }
                        // increase i by 1 and check 
                        else
                        {
                            if (matrix[i + 1, j-1] != Element.Key.ToString())
                            {
                                matrix[AgentVeritcalIndex, AgentHorizantalIndex] = "Null";
                                matrix[i+1, j-1] = Element.Agent.ToString();
                                Console.WriteLine("\n \n Next Iteration");
                                CreateMatrix.Construct(ref matrix);
                                stepsPerformed++;
                                if ((GetAgentIndex(matrix).Item1 == TargetVerticalIndex) && (GetAgentIndex(matrix).Item2 == TargetHorizantalIndex))
                                {
                                    Console.WriteLine("Agent Reached to Destination");
                                    success = true;



                                    break;

                                }
                                else
                                {
                                    Compute(ref matrix);

                                }
                            }

                        }
                        continue;
                       

                    }
                    else
                    {
                        matrix[AgentVeritcalIndex, AgentHorizantalIndex] = "Null";
                        matrix[i, j] = Element.Agent.ToString();
                        Console.WriteLine("\n \n Next Iteration");
                        CreateMatrix.Construct(ref matrix);
                        stepsPerformed++;
                        if ((GetAgentIndex(matrix).Item1 == TargetVerticalIndex) && (GetAgentIndex(matrix).Item2 == TargetHorizantalIndex))
                        {
                            Console.WriteLine("Agent Reached to Destination");
                            success = true;


                            break;

                        }
                        else
                        {
                            if (success)
                                break;
                            Compute(ref matrix);

                        }
                    }
                }

                
                break;


            }
        }

        // Not used,
        private static List<Tuple<int, int>> GetRationalPositions(ref String[,] matrix, int verticalIndex, int horizantalIndex)
        {
            List<Tuple<int, int>> list = new List<Tuple<int, int>>();

          
            if ((verticalIndex == 10) && (horizantalIndex < 10))
            {
                if (matrix[verticalIndex - 1, horizantalIndex] != Element.Key.ToString())
                {
                    list.Add(new Tuple<int, int>(verticalIndex, horizantalIndex - 1));
                }

            }

            for (int i = verticalIndex; i <= 10; i++)
            {
                for (int j = horizantalIndex; j <= 10; j++)
                {

                }
            }

            return list;
        }

        private static Tuple<int, int> GetTargetIndex(String[,] matrix)
        {
            int firstIndex = 0;
            int secondIndex = 0;
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    if (matrix[i, j] == Element.Target.ToString())
                    {
                        firstIndex = i;
                        secondIndex = j;
                    }

                }
            }

            return new Tuple<int, int>(firstIndex, secondIndex);
        }


        private static Tuple<int, int> GetAgentIndex(String[,] matrix)
        {
            int firstIndex = 0;
            int secondIndex = 0;
            for (int i = 1; i <= 10; i++)
            {
                for (int j = 1; j <= 10; j++)
                {
                    if (matrix[i, j] == Element.Agent.ToString())
                    {
                        firstIndex = i;
                        secondIndex = j;
                    }

                }
            }

            return new Tuple<int, int>(firstIndex, secondIndex);
        }
    }
}

