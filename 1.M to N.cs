using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CSLight
{


    internal class Program
    {
        static void PrintNumbersBetween(int value1, int value2)
        {
            if (value1 == value2)     //базовый случай
            {
                Console.Write(value1);
                return;
            }

            if (value1 < value2)      //рекурсивный, для всех чисел из промежутка M < N
            {
                Console.Write(value1 + "  ");
                PrintNumbersBetween(value1 + 1, value2);
            }
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Задайте значение для M: ");
            int m = int.Parse(Console.ReadLine());

            Console.WriteLine("Задайте значение для N: ");
            int n = int.Parse(Console.ReadLine());

            if (m > n) Console.WriteLine("По условию задачи M < N");  //лучше вынести из тела метода и проверять сразу

            PrintNumbersBetween(m, n);
        }

    }                      
}

