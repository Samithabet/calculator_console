using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asiment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter first number...");
            
            int first_num=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter second number...");

            int second_num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter opration ");
            string opration=Console.ReadLine();
            while (true) { }
            switch (opration)
            {
                case"+":
                    Console.WriteLine(first_num + second_num);
                    break;
                case "-":
                    Console.WriteLine(first_num + second_num);
                    break;
                case "*":
                    Console.WriteLine(first_num + second_num);
                    break;
                case "/":
                    Console.WriteLine(first_num + second_num);
                    break;


            }
            Console.ReadKey();

        }
    }
}
