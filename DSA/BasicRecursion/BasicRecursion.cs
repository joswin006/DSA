using DSA.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.BasicRecursion
{
    public class BasicRecursion
    {
        public void printnNTimes(int n)
        { 
            if (n == 0) return;
            Console.WriteLine("*");
            printnNTimes(n - 1);
        }

        //public void printbasicpattern(int n)
        //{

        //    if (n == 0) Console.WriteLine();
        //    Console.Write("*"+" ");
        //    printbasicpattern(n - 1);
        //}

    }
}
