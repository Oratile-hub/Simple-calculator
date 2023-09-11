using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number");
            double num2 = Convert.ToInt32(Console.ReadLine());
            double num3 = num1 + num2;

            Console.WriteLine(num1 + " + " + num2 + " = " + num3);



            //freeze console
            Console.ReadLine();


        }
    }
}
