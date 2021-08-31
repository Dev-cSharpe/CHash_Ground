using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterManipulation
{
    public class StringManipulation
    {
        public void StringCalculation()
        {
            Console.Write("Enter first string: ");
            string str1 = Console.ReadLine();

            // Convert the string into a byte[].
            byte[] str1AsciiValue = Encoding.ASCII.GetBytes(str1);

            double valuesForFirstString = 0;
            foreach (double item in str1AsciiValue)
            {
                valuesForFirstString += item;
            }
            //Reading Second Number  
            Console.Write("Enter second string: ");
            string str2 = Console.ReadLine();

            // Convert the string into a byte[].
            byte[] str2AsciiValue = Encoding.ASCII.GetBytes(str2);
            double valuesForSecondString = 0;

            foreach (double item in str2AsciiValue)
            {
                valuesForSecondString += item;
            }
            Console.WriteLine("Please select he operation that you want to perform : ");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Divsion");
            Console.WriteLine("4. Multiplication");
            int c = Convert.ToInt16(Console.ReadLine());
            int computedValue = 0;
            char character1 = 'H';
            string text1 = "";
            switch (c)
            {
                case 1:
                    computedValue = Convert.ToInt16(valuesForFirstString + valuesForSecondString);
                    if ((valuesForFirstString + valuesForSecondString) > 127)
                    {
                        computedValue = Convert.ToInt16(valuesForFirstString) % Convert.ToInt16(valuesForSecondString);
                    }
                    character1 = (char)computedValue;
                    text1 = character1.ToString();
                    Console.WriteLine("Addition of two string is : " + text1);
                    Console.WriteLine("Press enter to exit");
                    break;
                case 2:
                    computedValue = Convert.ToInt16(valuesForFirstString - valuesForSecondString);
                    if ((valuesForFirstString + valuesForSecondString) > 127)
                    {
                        computedValue = Convert.ToInt16(valuesForFirstString) % Convert.ToInt16(valuesForSecondString);
                    }
                    character1 = (char)computedValue;
                    text1 = character1.ToString();
                    Console.WriteLine("Subtraction oftwo string is : " + text1);
                    Console.WriteLine("Press enter to exit");
                    break;
                case 3:
                    computedValue = Convert.ToInt16(valuesForFirstString / valuesForSecondString);
                    if ((valuesForFirstString + valuesForSecondString) > 127)
                    {
                        computedValue = Convert.ToInt16(valuesForFirstString) % Convert.ToInt16(valuesForSecondString);
                    }
                    character1 = (char)computedValue;
                    text1 = character1.ToString();
                    Console.WriteLine("Division of two numbers : " + text1);
                    Console.WriteLine("Press enter to exit");
                    break;
                case 4:
                    computedValue = Convert.ToInt16(valuesForFirstString * valuesForSecondString);
                    if ((valuesForFirstString + valuesForSecondString) > 127)
                    {
                        computedValue = Convert.ToInt16(valuesForFirstString) % Convert.ToInt16(valuesForSecondString);
                    }
                    character1 = (char)computedValue;
                    text1 = character1.ToString();
                    Console.WriteLine("Multiplicaion of two numbers : " + text1);
                    Console.WriteLine("Press enter to exit");
                    break;
                default:
                    Console.WriteLine("Choose only 1 to 4 ");
                    Console.WriteLine("Press enter to exit");
                    break;
            }
            Console.ReadLine();
        }
    }
}
