using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Extensions
{
    public static class PrintExtension
    {

        public static void PrintArray(this List<int> arr)
        {
            foreach(var item in arr)
            {
                Console.Write(item + " ");
            }
        }

        public static void PrintInt(this int n) => Console.WriteLine(n);

        public static void PrintBool(this bool n) => Console.WriteLine(n);
    }
}
