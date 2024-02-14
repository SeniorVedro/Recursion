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
        static void PrintReverseArray(int[] newArray, int i)
        {

            if (i == 0)
            {
                Console.Write(newArray[i]);
                return;
            }

            Console.Write(newArray[i] + "  ");

            PrintReverseArray(newArray, --i);

        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[] myArray = new int[rnd.Next(5, 10)];    //генерация количества элементов 

            for (int i = 0; i < myArray.Length; i++)
                myArray[i] = rnd.Next(0, 100);          //генерация значения элемента

            Console.WriteLine(string.Join("  ", myArray));    // вывод изначального массива (для сравнения)


            int startIndex = myArray.Length - 1;

            PrintReverseArray(myArray, startIndex);
        }

    }                      
}

