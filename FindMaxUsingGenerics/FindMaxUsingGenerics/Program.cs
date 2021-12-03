using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxUsingGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to Find Maximum problem using Generics..!");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine("1)Maximum in Integer   2)Maximum in Float");
            Console.WriteLine("---------------------------------------------------");
            Console.Write("Enter your choice : ");
            int choice = int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    Maximum.ShowMaxInt();
                    break;
                case 2:
                    Maximum.ShowMaxFloat();
                    break;
                default:
                    Console.WriteLine("Invalid Choice !!!");
                    break;
            }
            Console.ReadKey();
        }
    }
}
