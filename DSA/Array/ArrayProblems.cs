using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Array
{
    public class ArrayProblems
    {
        public List<int> array;
        public int? number;
        public ArrayProblems(List<int> arr, int? num)
        {
            array = arr;
            number = num;
        }

        //using sorting but sorting takes a lot for time
        public int LargestElementInArrayBruteForce()
        {
            int largest = 0;
            array.Sort();
            return array[array.Count - 1];
        }


        //Takes O(n) time 
        public int CountDigitsBrute()
        {
            int count = 0;
            while (number != 0)
            {
                count++;
                number = number / 10;
            }
            return count;
        }


        public int CountDigitsInLogTime() => (int)(Math.Log10((double)number) + 1);

        public int reverse()
        {
            int reversed = 0;
            while (number != 0)
            {
                int ld = (int)number % 10;
                reversed = (reversed * 10) + ld;
                number /= 10;
            }
            return reversed;
        }

        public int Palindrome()
        {
            int reversed = 0;
            while (number != 0)
            {
                int ld = (int)number % 10;
                reversed = (reversed * 10) + ld;
                number /= 10;
            }
            if (number == reversed) return 1;
            return 0;
        }

        public int AmstrongNumber()
        {
            int numberofdigits = CountDigitsInLogTime();
            int amstrong = 0;
            int comparer = (int)number;
            while (number != 0)
            {
                int ld = (int)number % 10;
                amstrong += (int)Math.Pow(ld, numberofdigits);
                number /= 10;
            }
            if (comparer == amstrong) return 1;
            return 0;
        }

        //this here takes O(n) time since its iterating throung all the array elements.
        //since it takes lot of time suppose what if  size is too large?
        public List<int> printAllDivisiors()
        {
            var anslist = new List<int>();
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0) anslist.Add(i);
            }
            return anslist;
        }

        // in log time
        //how it works?
        //so if a number divedes 153 
        // 1   % 153 == 0
        //153  % 1   == 0
        //so need to loop it until last
        public List<int> printAllDivisiorsInLogTime()
        {
            var anslist = new List<int>();
            for (int i = 1; i * i <= number; i++)
            {
                if (number % i == 0)
                {
                    anslist.Add(i);
                    if ((number % i) != i) anslist.Add((int)(number / i));
                }

            }
            anslist.Sort();
            return anslist;
        }

        //a number which is divided by 1 and itself is prime
        public bool CheckPrime()
        {
            bool isPrime = false;
            int count = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }

            }
            return count == 2 ? true : false;
        }

        //takes O(n) time to loop through all.
        //is there any better way? yes Euclidean algo
        public int HcfOrGcdBrute(int a, int b)
        {
            int gcd = 0;
            int smaller = (a < b) ? a : b;
            for (int i = 1; i <= smaller; i++)
            {
                if (a % i == 0 && b % i == 0) gcd = i;
            }
            return gcd;
        }

        //gcd(a,b) = gcd(a-b,b) where b is smaller or a is greater
        //takes log time
        public int HcfOrGcdBruteEuclidean(int a, int b)
        {
            int gcd = 0;
            while (a != 0 && b != 0)
            {
                if (a > b) a = a % b;
                else b = b % a;
            }
            return a == 0 ? b : a;
        }
    }
}
