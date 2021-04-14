using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrozenLakeAIProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrix=CreateMatrix.Construct();
            Iterate.Compute(ref matrix);
            Console.WriteLine("\n \n Total Battery points are :  " + Convert.ToString(10000 - Iterate.stepsPerformed));
            Console.ReadLine();
        }
    }


}
