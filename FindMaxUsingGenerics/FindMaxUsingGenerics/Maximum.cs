﻿using System;
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
            Console.Write("Enter First number : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Second number : ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter Third number : ");
            int num3 = int.Parse(Console.ReadLine());
            if((num1.CompareTo(num2)>0&&(num1.CompareTo(num3)>0)))
            {
                return num1;
            }
            else if((num2.CompareTo(num3) > 0 && (num2.CompareTo(num1) > 0)))
            {
                return num2;
            }
            else if((num3.CompareTo(num1) > 0 && (num3.CompareTo(num2) > 0)))
            {
                return num3;
            }
            else
            {
                Console.WriteLine("Numbers are equal");
            }
            return 0;
        }
        public static void ShowMaxInt()
        {
            Console.Write("Maximum number is : " + FindMaxInt());
        }
        public static float FindMaxFloat()
        {
            Console.Write("Enter First number : ");
            float num1 = float.Parse(Console.ReadLine());
            Console.Write("Enter Second number : ");
            float num2 = float.Parse(Console.ReadLine());
            Console.Write("Enter Third number : ");
            float num3 = float.Parse(Console.ReadLine());
            if ((num1.CompareTo(num2) > 0 && (num1.CompareTo(num3) > 0)))
            {
                return num1;
            }
            else if ((num2.CompareTo(num3) > 0 && (num2.CompareTo(num1) > 0)))
            {
                return num2;
            }
            else if ((num3.CompareTo(num1) > 0 && (num3.CompareTo(num2) > 0)))
            {
                return num3;
            }
            else
            {
                Console.WriteLine("Numbers are equal");
            }
            return 0;
        }
        public static void ShowMaxFloat()
        {
            Console.Write("Maximum number is : " + FindMaxFloat());
        }
    }
}
