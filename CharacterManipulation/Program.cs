using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterManipulation
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("Press number from the below options: ");
                Console.WriteLine();
                Console.WriteLine("1. Number");
                Console.WriteLine("2. String");
                int strNumOptionSelected = Convert.ToInt16(Console.ReadLine());

                switch (strNumOptionSelected)
                {
                    case 1:
                        NumberManipulation numberManipulationObj = new NumberManipulation();
                        numberManipulationObj.NumberCalculation();
                        Console.WriteLine("Press enter to exit");
                        break;
                    case 2:
                        StringManipulation stringManipulationObj = new StringManipulation();
                        stringManipulationObj.StringCalculation();
                        Console.WriteLine("Press enter to exit");
                        break;
                    default:
                        Console.WriteLine("Please choose from 1 & 2 ");
                        Console.WriteLine("Press enter to exit and try again");
                        break;
                }
                Console.ReadLine();



                //if (strNumOptionSelected == 1)
                //{
                //    NumberManipulation numberManipulationObj = new NumberManipulation();
                //    numberManipulationObj.NumberCalculation();
                //}
                //else if (strNumOptionSelected == 2)
                //{
                    
                //    StringManipulation stringManipulationObj = new StringManipulation();
                //    stringManipulationObj.StringCalculation();
                //}
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("Value was either too large or too small for an Int64."))
                {
                    Console.WriteLine("Press provide atmost of 19 digit number and try again!!");
                    Console.ReadLine();
                }
                else if(ex.Message.Contains("Attempted to divide by zero."))
                {
                    Console.WriteLine("Attempted to divide by zero, so please try again!!");
                    Console.ReadLine();
                }
            }
        }
    }

}