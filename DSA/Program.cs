using DSA.Array;
using DSA.Extensions;
using System.Runtime.InteropServices;


List<int> array = new List<int>{1,4,75,92,23};
int? number = 10;
ArrayProblems arrayProblems = new ArrayProblems(array, number);

//arrayProblems.printAllDivisiors().PrintArray();
//arrayProblems.printAllDivisiorsInLogTime().PrintArray();
arrayProblems.CheckPrime().PrintBool();
arrayProblems.HcfOrGcdBrute(12,6).PrintInt();
arrayProblems.HcfOrGcdBruteEuclidean(12, 6).PrintInt();
//arrayProblems.AmstrongNumber().PrintInt();
//arrayProblems.LargestElementInArrayBruteForce().PrintInt();
//arrayProblems.CountDigitsInLogTime().PrintInt();
////arrayProblems.CountDigitsBrute().PrintInt();
//arrayProblems.reverse().PrintInt();


//array.PrintArray();
