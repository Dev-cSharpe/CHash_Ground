using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterManipulation
{
    public class NumberManipulation
    {
        public void NumberCalculation()
        {
            Console.Write("Enter first number: ");
            long a = Convert.ToInt64(Console.ReadLine());
            //Reading Second Number  
            Console.Write("Enter second number: ");
            long b = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Divsion");
            Console.WriteLine("4. Multiplication");
            //Reading a Choice  
            int c = Convert.ToInt16(Console.ReadLine());
            switch (c)
            {
                case 1:
                    Console.WriteLine("Addition of two numbers : " + (a + b));
                    Console.WriteLine("Press enter to exit");
                    break;
                case 2:
                    Console.WriteLine("Subtraction of two numbers : " + (a - b));
                    Console.WriteLine("Press enter to exit");
                    break;
                case 3:
                    Console.WriteLine("Division of two numbers : " + (a / b));
                    Console.WriteLine("Press enter to exit");
                    break;
                case 4:
                    Console.WriteLine("Multiplicaion of two numbers : " + (a * b));
                    Console.WriteLine("Press enter to exit");
                    break;
                default:
                    Console.WriteLine("Choose Only 1 To 4 ");
                    Console.WriteLine("Press enter to exit");
                    break;
            }
            Console.ReadLine();
        }
    }
}
