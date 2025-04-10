using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DSA.ArrayProb
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
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] > largest) largest = arr[i];
            }
            for (int i = 0; i < arr.Count; i++)
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
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] > largest)
                {
                    slargest = largest;
                    largest = arr[i];
                }
                else if (arr[i] > slargest && arr[i] < largest)
                {
                    slargest = arr[i];
                }
            }
            return slargest;
        }


        public bool CheckWhetherItIsASortedArray(List<int> arr)
        {
            for (int j = 1; j < arr.Count; j++)
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
            for (int j = 1; j < arr.Length; j++)
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
            for (int i = 0; i < k; i++)
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

        public int[] RotateKTimes(int[] nums, int k)
        {
            int numberOfTimesToRotate = k % nums.Length;//how it works? 7 times rotate anums.Length = 7 | ie so 7 % 7 = 0 rotation
                                                        //no need to do it for 7 times
                                                        //3 times rotate nums.Length = 15 20 % 5 = 5

            Array.Reverse(nums);
            Array.Reverse(nums, 0, k);
            Array.Reverse(nums, k, nums.Length - k);
            return nums;
        }

        //optimal 2 pointers at 2 different array
        // how brute works here just put it inside a set it will work 
        //reason set remobes duplicates and this approch gives us a extra space
        public List<int> UnionArray(int[] firstArray, int[] sccondArray)
        {
            List<int> unnionArr = new List<int>();
            int n1 = firstArray.Length - 1;
            int n2 = firstArray.Length - 1;
            int i = 0;
            int j = 0;
            while (i <= n1 && j <= n2)
            {
                if (firstArray[i] <= sccondArray[j])
                {
                    if (unnionArr.Last() != firstArray[i]
                    || unnionArr.Count == 0)
                    {
                        unnionArr.Add(firstArray[i]);
                    }
                    i++;
                }
                else
                {
                    if (unnionArr.Last() != sccondArray[j]
                    || unnionArr.Count == 0)
                    {
                        unnionArr.Add(sccondArray[j]);
                    }
                    j++;
                }

            }
            while (i <= n1)
            {

                if (unnionArr.Last() != firstArray[i]
                || unnionArr.Count == 0)
                {
                    unnionArr.Add(firstArray[i]);
                }
                i++;
            }
            while (j <= n2)
            {
                if (unnionArr.Last() != sccondArray[j]
                   || unnionArr.Count == 0)
                {
                    unnionArr.Add(sccondArray[j]);
                }
                j++;
            }
            return unnionArr;
        }

        //find missing num from 0 t0 n
        //takes O(n2) at worst case since it runs two loops
        //is there any better ap[proch ? yes
        public int MissingNumberBrute(int[] arr)
        {
            var missing = -1;
            for(int i=0;i<arr.Length;i++)
            {
                int flag = 0;
                for(int j=0;j<arr.Length;j++)
                {
                    if(i == arr[j])
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0) missing = i;
            }
            return missing;
        }

        //time complexity is O(n) + O(n) its ok but space it takes a extra space hoe to resolve it?
        //is there any better way yes
        public int MissingNumbersBetter(int[] arr)
        {
            int[] Hasharr = new int[arr.Length + 1];
            var missing = -1;
            for(int i = 0;i<arr.Length;i++)
            {
                Hasharr[arr[i]] = 1;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 1) missing = i + 1;
            }

            return missing;

        }
        //there are two optimals one is using sum of n natural nums n*m(n+1)/2 and using xor symbol ^
        // 2 ^ 2 =0 and 2 ^ 0 = 2

        public int MissingNumberOptimal1(int[]arr)
        {
            var missing = -1;
            var expectedsum = arr.Length * (arr.Length + 1) / 2;
            var actualsum = 0;
            foreach(var item in arr)
            {
                actualsum += item;
            }
            return missing = expectedsum - actualsum;
        }


    }
}
