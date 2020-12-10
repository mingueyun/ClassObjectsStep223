using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObjectsStep223
{
   public class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
          

            Console.WriteLine(" What number you want to do the math operations.?\n ");
            int mathOperations = Convert.ToInt32(Console.ReadLine());
            int firstMath = math.mathstuff1(mathOperations);
            int secondtMath = math.mathstuff2(mathOperations);
            int ThirdMath = math.mathstuff3(mathOperations);
            Console.WriteLine("First math: " + firstMath + "\nSecond math : " + secondtMath + "\nThird Math : " + ThirdMath);
            Console.ReadLine();



        }
    }
}
