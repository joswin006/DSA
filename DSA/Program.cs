﻿using DSA.ArrayProb;
using DSA.BasicRecursion;
using DSA.Extensions;
using System.Runtime.InteropServices;

//int[] missingnumarr = new int[] { 1, 2, 3, 4, 5 };
List<int> array = new List<int>{1,4,75,9211,213};
int[] sortedArray = new int[] { 1,1, 2, 3, 4, 4, 4, 5, 5, 6 };
int? number = 10;
ArrayProblems arrayProblems = new ArrayProblems(array, number);

//arrayProblems.printAllDivisiors().PrintArray();
//arrayProblems.printAllDivisiorsInLogTime().PrintArray();
//arrayProblems.CheckPrime().PrintBool();
//arrayProblems.HcfOrGcdBrute(12,6).PrintInt();
//arrayProblems.HcfOrGcdBruteEuclidean(12, 6).PrintInt();
//arrayProblems.AmstrongNumber().PrintInt();
//arrayProblems.LargestElementInArrayBruteForce().PrintInt();
//arrayProblems.CountDigitsInLogTime().PrintInt();
////arrayProblems.CountDigitsBrute().PrintInt();
//arrayProblems.reverse().PrintInt();


//array.PrintArray();


//arrayProblems.SecondLargestBrute(array).PrintInt();
//arrayProblems.secondLargest(array).PrintInt();
//arrayProblems.CheckWhetherItIsASortedArray(array).PrintBool();
//arrayProblems.RemoveDuplicatesFromSortedArrayBrute(sortedArray).PrintArray();
//arrayProblems.RemoveDuplicatesFromSortedArray(sortedArray).PrintArray();
//arrayProblems.rotate(sortedArray).PrintArray();
//arrayProblems.RotateKTimes(sortedArray,3).PrintArray();
//arrayProblems.MissingNumberBrute(new int[] { 0, 2, 5, 1 }).PrintInt();
//arrayProblems.MissingNumbersBetter(new int[] { 0, 2, 4, 1 }).PrintInt();
arrayProblems.MissingNumberOptimal1(new int[] { 0, 2, 4, 1 }).PrintInt();




BasicRecursion basicRecursion = new BasicRecursion();

//basicRecursion.printbasicpattern(5);
