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

        //it works but is it better?
        //not right bcaz we are using 2 passes here like 2 time for loop
        //so tc will be O(n) + O(n) can we simplify it? like can we do it in a single pass?
        //yes

        public int SecondLargestBrute(List<int> arr)
        {
            int slargest = 0;
            int largest = 0;
            for(int i=0;i<arr.Count;i++)
            {
                if (arr[i] > largest) largest = arr[i];
            }
            for(int i=0;i<arr.Count;i++)
            {
                if (arr[i] > slargest && arr[i] != largest)
                {
                    slargest = arr[i];
                }
            }
            return slargest;
        }
        //in a single pass

        public int secondLargest(List<int> arr)
        {
            int slargest = 0;
            int largest = arr[0];
            for (int i =0;i< arr.Count;i++)
            {
                if (arr[i] > largest)
                {
                    slargest = largest;
                    largest = arr[i];
                }
                else if (arr[i]>slargest && arr[i]<largest)
                {
                    slargest = arr[i];
                }
            }
            return slargest;
        }


        public bool CheckWhetherItIsASortedArray(List<int> arr)
        {
            for(int j= 1;j<arr.Count;j++)
            {
                if (arr[j - 1] < arr[j]) { }
                else return false;
            }
            return true;
        }

        //easy brute we think of using a hashset or disctionary hashset removes duplictes automatically
        //its ok to use this but space complexity? like it takes more right?O(n)
        //is there a better way to do this?
        //yes using a two pointer approach
        public List<int> RemoveDuplicatesFromSortedArrayBrute(int[] arr)
        {
            var set = new HashSet<int>(arr).ToList();
            return set;
        }

        //{ 1,1, 2, 3, 4, 4, 4, 5, 5, 6 }
        //simple one pass
        public List<int> RemoveDuplicatesFromSortedArray(int[] arr)
        {
            int i = 0;
            for(int j=1;j<arr.Length;j++)
            {
                if (arr[i] != arr[j])
                {
                    arr[i + 1] = arr[j];
                    i++;
                }
            }
            return arr.ToList();
        }

        public int[] Rotate(int[] nums, int k)
        {
            for(int i=0;i<k;i++)
            {
                rotate(nums);
            }
            return nums;
        }

        public int[] rotate(int[] nums)
        {
            int last = nums[nums.Length - 1];
            for (int i = nums.Length - 1; i > 0; i--)
            {
                nums[i] = nums[i - 1];
            }
            nums[0] = last;
            return nums;
        }



    }
}
