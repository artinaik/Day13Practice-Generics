using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMaxUsingGenerics
{
    class Maximum
    {
        public static int FindMaxInt()
        {
            Console.Write("Enter how many numbers you want to comapare : ");
            int size = int.Parse(Console.ReadLine());
            int[] array = new int[size];
            int count = 1;
            for(int i=0;i<size;i++)
            {
                Console.Write("Enter {0} number : ",count);                
                array[i]= int.Parse(Console.ReadLine());
                count++;
            }
            Array.Sort(array);
            int max = array[size - 1];
            return max;
        }
        public static void ShowMaxInt()
        {
            Console.Write("Maximum number is : " + FindMaxInt());
        }
        public static float FindMaxFloat()
        {
            Console.Write("Enter how many numbers you want to comapare : ");
            int size = int.Parse(Console.ReadLine());
            float[] array = new float[size];
            int count = 1;
            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter {0} number : ", count);
                array[i] = float.Parse(Console.ReadLine());
                count++;
            }
            Array.Sort(array);
            float max = array[size - 1];
            return max;
        }
        public static void ShowMaxFloat()
        {
            Console.Write("Maximum number is : " + FindMaxFloat());
        }
        public static string FindMaxString()
        {
            Console.Write("Enter how many strings you want to comapare : ");
            int size = int.Parse(Console.ReadLine());
            string[] array = new string[size];
            int count = 1;
            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter {0} string : ", count);
                array[i] =Console.ReadLine();
                count++;
            }
            Array.Sort(array);
            string max = array[size - 1];
            return max;

        }
        public static void ShowMaxString()
        {
            Console.Write("Maximum string is : " + FindMaxString());
        }
    }
}
