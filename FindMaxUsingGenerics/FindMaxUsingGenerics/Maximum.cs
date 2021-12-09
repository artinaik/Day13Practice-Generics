using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxUsingGenerics
{
    public class Maximum<T> where T : IComparable 
    {
        public static T FindMax()
        {
            Console.Write("Enter how many elements you want to comapare : ");
            int size = int.Parse(Console.ReadLine());
            T[] array = new T[size];
            int count = 1;
            for (int i=0;i<size;i++)
            {
                Console.Write("Enter {0} element : ",count);
                string input =Console.ReadLine();
                array[i]=(T)Convert.ChangeType(input, typeof(T));
                count++;
            }
            Array.Sort(array);
            T max = array[size - 1];
            return max;
        }
        public static void ShowMax()
        {
            Console.Write("Maximum element is : " + FindMax());
        }
       
    }
}
