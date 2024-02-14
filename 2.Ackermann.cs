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
        static int Ackermann(int n, int m)
        {
            if (n == 0)
                return m + 1;

            if (n > 0 && m == 0)
                return Ackermann(n - 1, 1);

            return Ackermann(n - 1, Ackermann(n, m - 1));
        }


        static void Main(string[] args)
        {
            int n = 3;
            int m = 2;

            int result = Ackermann(n, m);
            Console.WriteLine(result);
        }

    }                      
}

