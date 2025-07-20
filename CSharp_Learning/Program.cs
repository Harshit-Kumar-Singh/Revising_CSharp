using System;
using System.Globalization;
using System.Runtime.Intrinsics.Arm;
namespace CSharp_Learning
{
    public class Program
    {
        static void Main()
        {

            /*
            Numbers
            int x = 10, y = 20, z = 30;
            long bigNumber = 900;
            System.Console.WriteLine(bigNumber.GetType());
            System.Console.WriteLine(long.MaxValue);
            System.Console.WriteLine(long.MinValue);


            //C# compiler always put number as double type casting is required
            double negativeNumber = -1.23;
            float negativeNumber2 = -1.25F;
            decimal negativeNumber3 = -1.27M; // this is very big numbers;
            Console.WriteLine(negativeNumber);
            Console.WriteLine(negativeNumber2);

            System.Console.WriteLine(float.MaxValue);
            
            */

            /* Converting string to numbers
            string textAge = "-23";
            int age = Convert.ToInt32(textAge); //int -> int32;
            //Runtime errors
            Console.WriteLine(age);*/

            // char ch = 'a';
            // ch += 'b';
            // Console.WriteLine(ch);

            int number = 00011232; // 11232 it will remove the leading zeros
                                   // to convert string to number for further processing

            // switch statement
            // switch (number)
            // {
            //     case 12312:
            //         System.Console.WriteLine("hi");
            //         break;
            //     default:
            //         System.Console.WriteLine("default");
            //         break;
            // }

            /* number formatter */

            // double value = 1000D / 2.3D;
            // System.Console.WriteLine(value);

            // System.Console.WriteLine(string.Format("{0:0.00}",value));
            // double money = -10 / 3D;
            // System.Console.WriteLine(money.ToString("C"));
            // System.Console.WriteLine(money.ToString("C",CultureInfo.CurrentCulture));
            // System.Console.WriteLine(money.ToString("C",CultureInfo.CreateSpecificCulture("en-IN")));
            // System.Console.WriteLine(money.ToString("C",CultureInfo.CreateSpecificCulture("en-GB")));


            /* tryparse function instead of converttoInt to get rid of unhandeled exception*/

            // Console.Write("Enter the number");
            // string input = Console.ReadLine();
            // int num = 0;
            // bool success = int.TryParse(input, out num);
            // if (success)
            // {
            //     System.Console.WriteLine("Number : {0}",num);// COMPOSIT FORMATTING
            // }
            // else
            // {
            //     System.Console.WriteLine("Failed to convert");
            // }


            /* @ VERBATAIN WILL IGNORE ALL THE ESCAPE CHARACTERS */
            // string name = @"Hello ""SOMETHING""";    
            // System.Console.WriteLine(name);

            char[] ch = new char[] { 'H', 'e' };

            object obj = new string(ch);
            System.Console.WriteLine(ch);
            string check = "He";
            if (check.Equals(obj)) System.Console.WriteLine("Same");
            else System.Console.WriteLine("Diff");

            if (check == obj) System.Console.WriteLine("Same");
            else System.Console.WriteLine("Diff");
            
             
            
        }
    }
}