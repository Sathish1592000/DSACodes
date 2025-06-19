// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

////operators
//bool isRainy = true;
//bool hasUmbrella = false;

//if (isRainy)
//{
//    Console.WriteLine("it is raining");
//}
//Console.WriteLine("not raining");
//int month;
//Console.WriteLine("enter the month");
//month=int.Parse(Console.ReadLine());
//string monthName;
//switch (month) 
//{
//    case 1: monthName = "Jan"; break;
//    case 2: monthName ="feb"; break;
//    case 3: monthName = "march"; break;
//    case 4:monthName = "april"; break;


//}
//Console.WriteLine("Enter the month number to see whise birthday are preset in there");
//int monthNum=int.Parse(Console.ReadLine());
//string monthNumName;
//switch(monthNum)
//{
//    case 1: monthNumName = "Arjun";break;
//        case 2:monthNumName = "Sannjith"; break;
//        case 3:monthNumName = "Uma";break;
//        case 4:monthNumName = "Dady and mummy"; break;

//}
////now using character 
//Console.WriteLine("enter the month i will give the birday boy/girl");
//char monthNameis = char.Parse(Console.ReadLine());
//string birthdayIs;

using System.Net.Sockets;
using System.Net;
using System.Runtime.InteropServices;
using System.Collections;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;
using System.Security.Principal;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Immutable;
using System.Globalization;
using System.ComponentModel.Design;
using System.Runtime.Intrinsics.X86;
using System.Collections.Specialized;
using System.Security.AccessControl;
using System.Reflection;
using System.Reflection.Metadata;

public class Problems
{
    public static void Main()
    {
        #region
        Problems prb = new Problems();
        //prb.callMethod();
        //prb.RandGame();
        //prb.Calculator();
        //long result = prb.SumOfSumOfDivisors(36);
        //Console.WriteLine(result);
        //prb.PrimeOrNot(2);
        //prb.Prim2(22);
        //prb.printNos(5);
        //prb.RocketLanding();
        //bool res=prb.IsValidMachineName("dddd");
        //Console.WriteLine(res);
        //List<long> list= prb.factorialNumbers(5);
        //foreach (long li in list) 
        //{
        //    Console.WriteLine(li);
        //}
        //int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
        //foreach(int i in arr) { Console.Write(" "+i); }
        //Console.WriteLine("\n");

        //prb.Reversearray(arr);
        //bool result= prb.PalindromePhrase("0P");
        //Console.WriteLine(result);
        //Console.ReadKey();

        //Hashing numbers 
        //int[] arr = { 1, 2, 3, 2, 3, 4, 4 };
        //Console.WriteLine("sending an array:");
        //foreach (int item in arr)
        //{
        //    Console.Write(item);
        //}
        //int[]result =prb.HashingMethod(arr);
        //foreach (int i in result) 
        //{
        //    Console.WriteLine(i);
        //}

        //hashing characters 
        //string s = "abcdefgabcdefghi";
        //char[] cas = s.ToArray();
        //foreach (char c in cas)
        //{
        //    Console.Write(c);
        //}
        //Console.WriteLine("\n");
        //int[] result = prb.hashingChar(cas);
        //foreach (int sr in result)
        //{
        //    Console.WriteLine(sr);
        //}
        //Console.Read();

        //int[] result = prb.bubblesort(new int[] { 13, 46, 24, 52, 20, 9 });
        //foreach (int k in result)
        //{

        //    Console.Write(" " + k);
        //}

        //int[] result = prb.InsertionSortP(new int[] { 13, 46, 24, 52, 20, 9 });
        //foreach (int i in result)
        //{
        //    Console.Write(" " + i);
        //}
        int[] arr = new int[] { 102, 103, 104, 1, 2, 3, 4, 5, 6, 10 };
        int[] arr1 = new int[] { 2, 2, 3, 4, 5 };
        int[] arr2 = new int[] { 1, 3, 4, 5 };
        int[] arr3 = new int[] { 1, 1, 2, 2, 3, 3, 4, 4, 5, 5 };
        int[] arr4 = new int[] { 0, 1, 2, 0, 0, 0, 1, 2, 1, 1, 2, 1, 2, 1 };
        int[] arr5 = new int[] { 2, 0, 2, 1, 1, 0 };
        int[] arr6 = new int[] { 3, 1, -2, -5, 2, -4 };
        int[] arr7 = new int[] { 2, 3, -2, 4 };
        //int low = 0;
        //int high = arr.Length - 1;
        ////prb.QuickSort(arr, low, high);
        ////Console.WriteLine("Sorted array: " + string.Join(", ", arr));
        //int n=arr.Length;
        //int i = 0;
        //prb.LeaderInanArray(arr);
        //Console.WriteLine(" array: " + string.Join(", ", arr));
        //List<int> result = prb.Leader2(arr);

        //foreach (int res in result) 
        //{
        //    Console.Write(" "+res);
        //}

        //prb.ReverseanArray(arr);
        //Console.WriteLine("reverse: " + string.Join(", ", arr));

        //Console.WriteLine($"Second largest element is : {prb.SecondLargest(arr)}");
        //int[] result = prb.RemoveDuplicate2(arr);
        // Console.WriteLine($"All the duplicates removed : "+result);
        //Console.WriteLine("Is Sorted "+prb.SorNot(arr));


        //List<int> arr = new List<int> {0,5,6,7,8,9,12,45};
        //int[] result = prb.ZerosOnesTwos(arr4);
        //Console.WriteLine(result);

        //foreach (int i in result)
        //{
        //    Console.WriteLine(" " + i);
        //    }

        int result1 = prb.maxProdBrt(arr7);
        Console.WriteLine("The max sub array is : " + result1);
        //int result1 = prb.MaxSubarraysmallandsecondsmall(arr3);
        //Console.WriteLine("The Maximum sub array is : " + result1);
        //bool result = prb.TwoSum1(arr, 9);
        //Console.WriteLine(result);

        /*Console.WriteLine(prb.EuclideanMeth(12,15));*/
        //Console.Read();

        #endregion
    }
    public void callMethod()
    {

        bool result = Archstrongornot(34);
        Console.WriteLine(result);
    }

    public bool Archstrongornot(int x)
    {
        int dup = x;
        int sum = 0;
        while (x > 0)
        {
            int ld = x % 10;
            sum += ld * ld * ld;
            x = x / 10;
        }
        if (sum == dup) return true;
        else return false;
    }

    public int largest(List<int> arr)
    {

        int n = arr.Count;
        int large = arr[0];
        // if (arr == null) return 0;
        for (int i = 0; i < n; i++)
        {
            if (arr[i] > large)
            {
                large = arr[i];
            }
        }
        return large;
    }

    public void RandGame()
    {
        Random rand = new Random();
        bool tryagain = false;
        int randonumber = rand.Next(1, 11);
        string userguess = "yes";
        while (userguess != "no")
        {
            Console.WriteLine("Guess the random number");
            string guessedstring = Console.ReadLine();
            int guessedNum;
            bool isNumber = int.TryParse(guessedstring, out guessedNum);
            if (isNumber)
            {
                if (guessedNum == randonumber) Console.WriteLine("yay!! it is correct!! Congratulation!!!!!");
                else Console.WriteLine("OOps!wrong number entered");
                Console.WriteLine("wanna try again");
                userguess = Console.ReadLine();

            }
            else Console.WriteLine("please enter a number");


        }
    }

    public void Calculator()
    {
        Console.WriteLine("Enter the two number to calculate");
        string num1 = Console.ReadLine();
        string num2 = Console.ReadLine();
        int numb1, numb2;
        bool isNumb1 = int.TryParse(num1, out numb1);
        bool isNum2 = int.TryParse(num2, out numb2);
        if (isNumb1 && isNum2)
        {
            Console.WriteLine("Please enter what operation u want to do");
            Console.WriteLine("\n Press 1 for addition +"); Console.WriteLine("\n Press 2 for Substraction -"); Console.WriteLine("\n Press 3 for division /");
            Console.WriteLine("\n Press 4 for Multiplication *");
            string operation = Console.ReadLine();
            int ops;
            bool isops = int.TryParse(operation, out ops);
            int result;
            if (isops && ops <= 4)
            {
                switch (ops)
                {

                    case 1: result = numb1 + numb2; Console.WriteLine("The answer is {0}", result); break;
                    case 2: result = numb1 - numb2; Console.WriteLine("The answer is {0}", result); break;
                    case 3: result = numb1 / numb2; Console.WriteLine("The answer is {0}", result); break;
                    case 4: result = numb1 * numb2; Console.WriteLine("The answer is {0}", result); break;
                }
            }
            else Console.WriteLine("please select anything from the above..Dont give random values!");

        }
        else
        {
            Console.WriteLine("Please enter a number boss!!");
        }

    }

    public long SumOfSumOfDivisors(int n)
    {
        long[] sumDivisors = new long[n + 1];

        // Efficiently calculate sum of divisors for all numbers from 1 to n
        for (int i = 1; i <= n; i++)
        {
            for (int j = i; j <= n; j += i)
            {
                sumDivisors[j] += i;
            }
        }

        // Sum up all F(i)
        long totalSum = 0;
        for (int i = 1; i <= n; i++)
        {
            totalSum += sumDivisors[i];
        }

        return totalSum;
    }

    public void PrimeOrNot(int n)
    {
        int flag = 0;
        for (int i = 2; i < n; i++)
        {
            if (n % i != 0) continue;
            else
            {
                flag = 1;
                Console.WriteLine("Nt a prime");
                break;
            }
        }
        if (flag == 0)
        {
            Console.WriteLine("prime");
        }


    }

    public void Prim2(int x)
    {
        int count = 0;
        for (int i = 1; i <= x; i++)
        {
            if (x % i == 0)
            {
                count++;

            }
        }
        if (count == 2)
        {
            Console.WriteLine("Prime");
        }
        else Console.WriteLine("Not a prime");
    }

    public void printNos(int n) //3,2,1
    {
        if (n == 0) return;
        printNos(n - 1);    //2 ,1,0
        Console.WriteLine(n);
    }

    public void RocketLanding()
    {
        string rocket =
 "     ^     \n" +
 "    / \\    \n" +
 "   /   \\   \n" +
 "  /     \\  \n" +
 " /_______\\ \n" +
 "    | |    \n" +
 "    | |    \n" +
 "    | |    \n" +
 "   /   \\   \n" +
 "  /_____\\  \n" +
 "   |   |   \n" +
 "   |   |   \n" +
 "   '---'   \n";

        Console.WriteLine(rocket);


        for (int i = 0; i < 10; i++)
        {
            Console.Clear();
            Console.WriteLine(rocket);
            rocket = "\r\n" + rocket;
            Thread.Sleep(1000);
        }
    }

    int fact = 1;

    public long factorial(long i)
    {
        if (i == 0) return 1;

        return i * factorial(i - 1);


    }
    public List<long> factorialNumbers(long n)
    {
        long i = 1;
        List<long> list = new List<long>();

        while (factorial(i) <= n)
        {

            list.Add(factorial(i));
            i++;
        }

        return list;

    }

    int i = 0, temp = 0;
    public void Reversearray(int[] arr)
    {

        int n = arr.Length;
        if (i >= n / 2) return;
        temp = arr[i];
        arr[i] = arr[n - i - 1];
        arr[n - i - 1] = temp;
        i += 1;
        Reversearray(arr);
        foreach (int i in arr)
        {

            Console.Write(" " + i);
        }
        Console.ReadKey();
    }

    int slength, si = 0;
    public bool PalindromePhrase(string s)
    {


        s = s.ToLower();
        s = Regex.Replace(s, "[^a-zA-Z]", "");
        char[] arr = s.ToCharArray();
        s = new string(s.Where(char.IsLetter).ToArray());
        slength = arr.Length;
        if (si >= slength / 2) return true;
        if (arr[si] != arr[slength - si - 1]) return false;
        si++;
        return PalindromePhrase(s);
    }

    public int[] HashingMethod(int[] arr)
    {
        int n = arr.Length;
        //preprocessing
        int[] hash = new int[n];
        List<int> list = new List<int>();

        for (int i = 0; i < n; i++)
        {
            hash[arr[i]] += 1;
            list[arr[i]] += 1;
        }
        return hash;
    }

    public int[] hashingChar(char[] arr)
    {
        int n = arr.Length;
        int[] hash = new int[n];
        //List<int> list = new List<int>();

        for (int i = 0; i < n; i++)
        {
            hash[arr[i] - 'a']++;
        }
        return hash;

    }

    //selection sorting
    public int[] selectionSort(int[] arr)//3,2,5,1
    {
        int n = arr.Length;

        for (int i = 0; i <= n - 2; i++)
        {
            int min = i;
            for (int j = i; j <= n - 1; j++)
            {
                if (arr[j] < arr[min])//find the small number in the indices
                    min = j;
            }
            //swap

            int temp = arr[i];
            arr[i] = arr[min];
            arr[min] = temp;
        }
        return arr;
    }

    public int[] bubblesort(int[] arr)

    {
        int n = arr.Length;
        for (int i = n - 1; i >= 0; i--)
        {
            for (int j = 0; j <= i - 1; j++)
            {
                int doswap = 0;
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    doswap++;
                }
                if (doswap == 0) break;
                Console.WriteLine("swapped !!");
            }

        }
        return arr;
    }

    public int[] insertionSwap(int[] arr) //521789
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            int j = i;
            while (j > 0 && arr[j - 1] > arr[j])
            {
                int temp = arr[j];
                arr[j] = arr[j - 1];
                arr[j - 1] = temp;
                j--;
            }
        }
        return arr;
    }

    public int NumberOfDigit(int num)
    {
        int Count = 0;
        while (num != 0)
        {
            int ld = num % 10;
            num /= 10;
            Count++;
        }
        return Count;
    }

    public int NumberOfDigitDivis(int num)
    {
        int Count = 0;
        string digit = num.ToString();
        foreach (char c in digit)
        {
            int dc = c - '0';
            if (dc == 0) continue;
            if (num % dc == 0)
            {
                int ld = dc % 10;
                dc /= 10;
                Count++;
            }
        }
        return Count;
    }

    public int RevNum(int num)
    {
        int revNum = 0;
        while (num != 0)
        {

            int ld = num % 10;
            num /= 10;
            if (revNum > (int.MaxValue / 10) || (revNum == int.MaxValue) && ld > 7) return 0;
            if (revNum < (int.MinValue / 10) || (revNum == int.MinValue) && ld < -8) return 0;
            revNum = (revNum * 10) + ld;
        }
        return revNum;
    }

    public int GCDorHCF(int n1, int n2) //Brute it is o(min(n1,n2)
    {
        int gcd = 1;
        for (int i = 1; i < Int32.Min(n1, n2); i++)
        {
            if (n1 % i == 0 && n2 % i == 0)
            {
                gcd = i;
            }
        }
        return gcd;
    }

    //Euclidean Algorithm for Ged and HCF is gcd (a,b) = gcd (a-b,b) Where a>b
    //Here to make it more optimized Instead of subracting till we get 0 we can divode it with b to make it simpler So (a%b,b)
    public int EuclideanMeth(int a, int b)
    {
        while (a > 0 && b > 0)
        {
            if (a > b) a = a % b;
            else b = b % a;
        }
        if (a == 0) return b;
        else return a;
    }

    //Running Sum Prob
    public int[] RunningSum(int[] nums)
    {
        int n = nums.Length, sum = 0;
        List<int> ans = new List<int>();
        //ans.Add(nums[0]);
        for (int i = 0; i < n; i++)
        {
            sum += nums[i];
            ans.Add(sum);
        }
        return ans.ToArray();
    }
    #region 

    //public int[] SelectionSort2(int[] a)
    //{
    //    int n = a.Length;

    //    for (int i = 0; i <= n - 2; i++)
    //    {
    //        int min = i;
    //        for (int j = i; j <= n - 1; j++)
    //        {
    //            if (a[j] < a[min])
    //            {
    //                min = j;
    //            }
    //        }
    //        //swap

    //        int temp = a[min];
    //        a[min] = a[i];
    //        a[i] = temp;
    //    }
    //    return a;

    //}

    //public int[] BubbleSort2(int[] b)
    //{
    //    int n = b.Length;
    //    int doSwap = 0;
    //    for (int i = n - 1; i >= 0; i--)
    //    {
    //        for (int j = 0; j <= i - 1; j++) //here it is i-1 bcs in the first iteration the last value in an array will be check anyways 
    //        {

    //            if (b[j] > b[j + 1])
    //            {
    //                int temp = b[j];
    //                b[j] = b[j + 1];
    //                b[j + 1] = temp;
    //                doSwap++;
    //            }
    //        }
    //        if (doSwap == 0) break;

    //    }
    //    return b;
    //}

    //public int[] InsertionSort2(int[] c) // 13, 46, 24, 52, 20, 9
    //{
    //    int n = c.Length;
    //    for (int i = 0; i <= n - 1; i++) 
    //    {
    //        int j = i;
    //        while (j > 0 && c[j - 1] > c[j])
    //        {
    //            int temp = c[j];
    //            c[j] = c[j-1];
    //            c[j-1] = temp;
    //            j--;
    //        }
    //    }      
    //    return c;
    //}
    #endregion

    public int[] SelectionSortP(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i <= n - 2; i++)
        {
            int min = i;
            for (int j = i; j <= n - 1; j++)
            {
                if (arr[j] < arr[min])
                {
                    min = j;
                }
            }
            int temp = arr[i];
            arr[i] = arr[min];
            arr[min] = temp;
        }
        return arr;
    }

    public int[] BubbleSortP(int[] arr)
    {
        int n = arr.Length;
        int doswap = 0;
        for (int i = n - 1; i >= 0; i--)
        {
            for (int j = 0; j <= i - 1; j++)
            {

                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    doswap++;
                }
            }
            if (doswap == 0) break;
        }
        return arr;
    }

    public int[] InsertionSortP(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i <= n - 1; i++)
        {
            int j = i;
            while (j > 0 && arr[j - 1] > arr[j])
            {
                int temp = arr[j];
                arr[j] = arr[j - 1];
                arr[j - 1] = temp;
                j--;
            }
        }
        return arr;
    }

    public int[] MergeSort(int[] arr, int low, int high)
    {
        int n = arr.Length;
        if (low >= high) return arr;
        int middle = low + high / 2;
        MergeSort(arr, low, middle);
        MergeSort(arr, middle + 1, high);
        int left = low;
        int right = middle + 1;
        int[] temp = [];
        while (left <= middle && right <= high)
        {
            if (arr[left] <= arr[right])
            {
                //add left element  to array
                temp = new int[] { arr[left] };
                left++;
            }
            else
            {
                //add right element to array 
                right++;
            }
        }
        //if one of the side is exhausted then add the remaining to the array 
        while (left <= middle)
        {
            //add to the temp array 
            left++;
        }
        while (right <= high)
        {
            //add to the temp array 
            right++;
        }
        //Put the value to the original array arr
        for (int i = low; i <= high; i++)
        {
            arr[i] = temp[i - low];
        }
        return arr;


    }
    #region
    public void MergeSort2(int[] arr, int low, int high) //5, 4, 6, 2, 3, 5, 6  // Time Complexity = N log base 2 n
    {
        if (low == high) return;
        int n = arr.Length;
        int middle = (low + high) / 2;
        MergeSort2(arr, low, middle);
        MergeSort2(arr, middle + 1, high);
        Merge(arr, low, middle, high);

    }
    public void Merge(int[] arr, int low, int middle, int high)
    {
        List<int> temp = new List<int>();
        int left = low;
        int right = middle + 1;
        while (left <= middle && right <= high)
        {
            if (arr[left] <= arr[right])
            {
                temp.Add(arr[left]);
                left++;
            }
            else
            {
                temp.Add(arr[right]);
                right++;
            }
        }
        while (left <= middle)
        {
            temp.Add(arr[left]);
            left++;

        }
        while (right <= high)
        {
            temp.Add(arr[right]);
            right++;
        }

        //put back in an original array from temp
        for (int i = low; i <= high; i++)
        {
            arr[i] = temp[i - low];
        }


    }
    #endregion

    public void QuickSort(int[] arr, int low, int high) ///5, 4, 6, 2, 3, 5, 6
    {
        if (low < high)
        {
            int partition = sfunc(arr, low, high);
            QuickSort(arr, low, partition - 1);
            QuickSort(arr, partition + 1, high);
        }

    }
    public int sfunc(int[] arr, int low, int high)
    {
        int pivot = arr[low];
        int i = low;
        int j = high;
        while (i < j)
        {
            while (arr[i] >= pivot && i <= high - 1) { i++; }

            while (arr[j] < pivot && j >= low + 1) { j--; }


            if (i < j)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
        int newtemp = arr[low];
        arr[low] = arr[j];
        arr[j] = newtemp;
        return j;

    }

    public void RecursiveBubble(int[] arr, int n)
    {
        //Base condition 
        if (n == 1) return;

        for (int i = 0; i <= n - 2; i++)
        {
            if (arr[i] > arr[i + 1])
            {
                int temp = arr[i];
                arr[i] = arr[i + 1];
                arr[i + 1] = temp;
            }

        }
        RecursiveBubble(arr, n - 1);
    }

    public void RecursiveInsertion(int[] arr, int i, int n)
    {
        if (n == i) return;
        while (i > 0 && arr[i - 1] > arr[i])
        {
            int temp = arr[i];
            arr[i] = arr[i - 1];
            arr[i - 1] = temp;
            i--;
        }
        RecursiveInsertion(arr, i + 1, n);
    }

    public int SecondLargest(int[] arr)
    {
        int largest = arr[0];
        int sLargest = Int16.MinValue;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > largest)
            {
                sLargest = largest;
                largest = arr[i];
            }
            if (arr[i] < largest && arr[i] > sLargest)
            {
                sLargest = arr[i];
            }
        }
        return sLargest;
    }

    public bool SorNot(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < arr[i + 1])
            {
                return true;
            }
            else
                return false;
        }
        return true;
    }

    //brute
    public int RemoveDuplicates(int[] arr) //1,1,2,2,3,3
    {
        int n = arr.Length;
        HashSet<int> set = new HashSet<int>();
        for (int i = 0; i < n; i++)
        {
            set.Add(arr[i]);
        }
        return set.Count;
    }

    //Optimal
    public int RemoveDuplicate2(int[] arr)
    {
        int n = arr.Length;
        int i = 0;
        for (int j = 1; j < n - 1; j++)
        {
            if (arr[i] != arr[j])
            {
                arr[i + 1] = arr[j];
                i++;
            }
        }
        return i + 1;
    }

    #region
    //Left Rotate by K places

    //Brute solution
    public void Rotate1(int[] arr, int k)
    {

        int n = arr.Length;
        k = k % n;
        int[] temp = new int[k];
        //store the value in temp
        for (int i = 0; i < k; i++)
        {
            temp[i] = arr[i];
        }
        //rotate by left
        for (int i = k; i < n; i++)
        {
            arr[i - k] = arr[i];
        }
        //Put back to the array
        for (int i = n - k; i < n; i++)
        {
            arr[i] = temp[i - (n - k)];
        }

    }

    //Optimized solution
    public void Rotate2(int[] arr, int k)
    {
        int n = arr.Length;
        k = k % n;
        Array.Reverse(arr, 0, k);
        Array.Reverse(arr, k, n - k);
        Array.Reverse(arr, 0, n);
    }

    //Right Rotate by k places 
    public void Rotate3(int[] arr, int k)
    {
        int n = arr.Length;
        k = k % n;
        Array.Reverse(arr);
        Array.Reverse(arr, 0, k);
        Array.Reverse(arr, k, n - k);
    }
    #endregion

    //Brute soln  TC= 0(n) +O(x)+ O(n-x) = O(2n)
    public void RemoveZeros(int[] arr) //[1,3,0,5,0,6]
    {
        int n = arr.Length;
        int[] temp = new int[n];
        int j = 0;
        //Take all the non-zero numbers and place it in the temp array
        for (int i = 0; i < n; i++)
        {
            if (arr[i] != 0) { temp[j] = arr[i]; j++; }
        }

        //Step2:Replace all the temp values i.e.non-zero values to the front of an array
        for (int i = 0; i < temp.Length; i++)
        {
            arr[i] = temp[i];
        }

        //Step3:Allocate the remaining place of arr to zeros
        for (int i = j + 1; i < n; i++)
        {
            arr[i] = 0;
        }
    }

    //Optimized Soln
    public void RemoveZeros2(int[] arr) //tc = O(x) , O(n-x) = O(x)+O(n-x)=O(n) ; SC=O(1)
    {
        int n = arr.Length;
        int j = -1;
        for (int i = 1; i < n - 1; i++)
        {
            if (arr[i] == 0)
            {
                j = i;
                break;
            }
        }

        if (j == -1) return;
        for (int i = j + 1; i < n; i++)
        {
            if (arr[i] != 0)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                j++;
            }
        }
    }


    //Brute -- Using SortedSet
    public int[] Union(int[] nums1, int[] nums2)
    {
        int[] union;
        SortedSet<int> set = new SortedSet<int>();
        foreach (int i in nums1)
        {
            set.Add(i);
        }
        foreach (int j in nums2)
        {
            set.Add(j);
        }
        return set.ToArray();
    }

    //int[] arr = new int[] { 1, 1, 2, 3, 4 };
    //int[] arr1 = new int[] { 2,2,3,4,5};
    public int[] Union2(int[] arr, int[] arr1)
    {
        int n = arr.Length;
        int n1 = arr1.Length;
        int i = 0;
        int j = 0;
        List<int> union = new List<int>();
        while (i < n && j < n1)
        {
            if (arr[i] <= arr1[j])
            {
                if (union.Count == 0 || union[^1] != arr[i])
                {
                    union.Add(arr[i]);
                }
                i++;
            }
            else
            {
                if (union.Count == 0 || union[^1] != arr1[j])
                {
                    union.Add(arr[j]);
                }
                j++;
            }
        }
        while (i < n)
        {
            if (union.Count == 0 || union[^1] != arr[i])
            {
                union.Add(arr[i]);
            }
            i++;
        }
        while (j < n1)
        {
            if (union.Count == 0 || union[^1] != arr1[j])
            {
                union.Add(arr1[j]);
            }
            j++;
        }

        return union.ToArray();
    }//TC==O(n1+n2) and SC =O(n1+n2)

    public int[] Intersection(int[] a, int[] b) //TC=O(n1+n2) SC=O(1)
    {
        int n1 = a.Length;
        int n2 = b.Length;
        int i = 0;
        int j = 0;
        List<int> intersect = new List<int>();
        while (n1 > i && n2 > j)
        {
            if (a[i] < b[j])
            {
                i++;
            }
            else if (b[j] < a[i])
            {
                j++;
            }
            else
            {
                intersect.Add(a[i]);
                i++; j++;
            }
        }
        return intersect.ToArray();
    }

    public int MissingNumber(int[] a)
    {
        int n = a.Length;
        int sum1 = n * (n + 1) / 2;
        int sum2 = 0;
        for (int i = 0; i < n - 1; i++)
        {
            sum2 += a[i];
        }
        return sum1 - sum2;
    } //TC =O(n) 

    public int MissingNumber1(int[] a)
    {
        int N = a.Length;
        int n = N - 1;
        int xor1 = 0, xor2 = 0;
        for (int i = 0; i < n; i++)
        {
            xor2 = xor2 ^ a[i];
            xor1 = xor1 ^ (i + 1);
        }
        xor1 = xor1 ^ n + 1;
        return xor1 ^ xor2;
    }

    public int FindMaxConsecutiveOnes(int[] nums)//TC =O(N) SC=(1)
    {
        int n = nums.Length;
        int max = 0, count = 0;
        for (int i = 0; i < n - 1; i++)
        {
            if (nums[i] == 1)
            {
                count++;
                max = Math.Max(max, count);
            }
            else { count = 0; }

        }
        return max;

    }
    public void ReverseanArray(int[] arr)
    {
        int n = arr.Length;
        int i = 0;
        int j = n - 1;
        while (i < n / 2)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
            i++;
            j--;
        }
    }

    public int NumAppOnce(int[] arr)
    {
        int n = arr.Length;
        int maxVal = arr.Max();
        int[] hash = new int[maxVal + 1];
        for (int i = 0; i < n; i++)
        {
            hash[arr[i]]++;
        }
        for (int i = 0; i < n; i++)
        {
            if (hash[arr[i]] == 1) return arr[i];
        }
        return -1;
    }

    public int NumAppOnce1(int[] arr)
    {
        int n = arr.Length;
        int XOR = 0;
        for (int i = 0; i < n; i++)
        {
            XOR = XOR ^ arr[i];
        }
        return XOR;
    }

    public int LongSubarray(int[] arr, int sa)
    {
        int n = arr.Length;
        int Longsub = 0, sum = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                for (int k = i; k < j; k++)
                {
                    sum += arr[k];
                    if (sum == sa)
                    {
                        Longsub = Math.Max(Longsub, sum);
                    }
                }
            }
        }
        return Longsub;

    }

    //longest sub array only for positive number and non -zeros
    public int LongSubarrayO(int[] arr, int k) //TC=(2N)
    {
        long sum = arr[0];
        int max = 0;
        int left = 0, right = 0;
        int n = arr.Length;
        while (right < n)
        {
            while (left <= right && sum > k)
            {
                sum -= arr[left];//subtract the element from the left and move the pointer to right 
                left++;
            }
            if (sum == k)
            {
                max = Math.Max(max, (right - left) + 1);
            }
            right++;
            if (right < n) { sum += arr[right]; } // move forward to find the longest sum

        }
        return max;
    }

    //optimal solution for longest subarray with sum k with positives ,negativesa and zeros 
    public int LongSubHash(int[] arr, int k)
    {
        Dictionary<long, int> map = new Dictionary<long, int>();
        long prefixSum = 0;
        int n = arr.Length, maxLen = 0;
        for (int i = 0; i < n; i++)
        {
            prefixSum += arr[i];
            if (prefixSum == k)
            {
                maxLen = Math.Max(maxLen, i + 1);
            }

            if (map.ContainsKey(prefixSum - k))
            {
                int rem = map[prefixSum - k];
                maxLen = Math.Max(maxLen, i - rem);
            }
            if (!map.ContainsKey(prefixSum))
            {
                map[prefixSum] = i;
            }
        }
        return maxLen;
    }

    //2Sum problem
    public int[] TwoSum(int[] arr, int T) //Better Soln using Hashing
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        int n = arr.Length;
        int total = 0;
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            int req = T - arr[i];
            if (map.ContainsKey(req))
            {
                //return true;
                return new int[] { map[req], i };
            }
            map[arr[i]] = i;
        }
        //return false;
        return new int[] { -1, -1 };

    } //TC = O(nlogn) //SC=O(N)

    public bool TwoSum1(int[] arr, int T) //O(n)+O(nlogn)
    {
        Array.Sort(arr);
        int n = arr.Length;
        int left = 0, right = n - 1;


        while (left < right)
        {
            int sum = arr[left] + arr[right];
            if (sum == T)
            {
                return true;
            }
            else if (sum < T) { left++; }
            else { right--; }
        }
        return false;
    }

    //ZerosOnesTwos Sort problem
    //Better solution 
    public int[] ZerosOnesTwos(int[] arr)
    {
        int n = arr.Length;
        int count0 = 0, count1 = 0, count2 = 0;
        for (int i = 0; i < n; i++)
        {
            if (arr[i] == 0) { count0++; }
            if (arr[i] == 1) { count1++; }
            if (arr[i] == 2) { count2++; }
        }
        for (int i = 0; i < count0; i++) { arr[i] = 0; }
        for (int i = count0; i < count0 + count1; i++) { arr[i] = 1; }
        for (int i = count0 + count1; i < n; i++) { arr[i] = 2; }
        return arr;
    }

    //Optimal solution using Dutch National Flag Algorithm 
    public int[] ZerosOnesTwos2(int[] arr) //TC=O(n);SC=O(1)
    {
        int n = arr.Length;
        int low = 0, mid = 0, high = n - 1;
        while (mid <= high)
        {
            if (arr[mid] == 0)
            {
                int temp = arr[low];
                arr[low] = arr[mid];
                arr[mid] = temp;
                low++;
                mid++;
            }
            else if (arr[mid] == 1) { mid++; }
            else
            {
                int temp = arr[mid];
                arr[mid] = arr[high];
                arr[high] = temp;
                high--;
            }
        }
        return arr;
    }

    //Majority element occurs >n/2 
    //Better Soln
    public int Majelements(int[] arr)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        int n = arr.Length;
        for (int i = 0; i < n; i++)
        {
            if (map.ContainsKey(arr[i]))
            {
                map[arr[i]]++;
            }
            else map[arr[i]] = 1;

        }
        foreach (var val in map)
        {
            if (val.Value > n / 2)
                return val.Key;
        }
        return -1;

    }

    //Moores's Voting Algorithm
    public int MooresAlgMajele(int[] arr)//TC=O(n)+O(n) SC=O(n)
    {
        int n = arr.Length;
        int ele = 0, count = 0;

        for (int i = 0; i < n; i++)
        {
            if (count == 0)
            {
                count = 1;
                ele = arr[i];
            }
            if (ele == arr[i]) { count++; }
            else count--;
        }
        int count1 = 0;
        for (int i = 0; i < n; i++)
        {
            if (arr[i] == ele) { count1++; }
            if (count1 > n / 2)
            {
                return ele;
            }
        }
        return -1;
    }

    //Maximum subarray Sum 
    //Brute force approach //TC=n(n^3) ,SC=O(1)
    public int MaxSubArray(int[] arr)
    {
        int n = arr.Length;

        int maxi = Int32.MinValue;
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                int sum = 0;
                for (int k = i; k <= j; k++)
                {
                    sum += arr[k];

                }
                maxi = Math.Max(sum, maxi);
            }
        }
        return maxi;
    }

    //Better approach -- Here we need to remove only the k loop and sum it with j loop //TC=n(n^2) ,SC=O(1)
    public int MaxSubArray1(int[] arr)
    {
        int n = arr.Length;

        int maxi = Int32.MinValue;
        for (int i = 0; i < n; i++)
        {
            int sum = 0;
            for (int j = i; j < n; j++)
            {
                sum += arr[j];
                maxi = Math.Max(sum, maxi);
            }
        }
        return maxi;
    }

    //Optimal approach - using kadane's algorithm
    //TC=O(n) SC=O(1)
    public int MaxSubArray2(int[] nums)
    {
        int n = nums.Length, max = nums[0], sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += nums[i];
            max = Math.Max(sum, max);
            if (sum < max)
            {
                sum = 0;
            }
        }
        return max;
    }

    //these are stacks kepp for later 
    public int MaxSubarraysmallandsecondsmall(int[] arr)
    {
        int n = arr.Length;
        int sum = 0;
        int max = int.MinValue;
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                int min1 = int.MaxValue, min2 = int.MaxValue;
                for (int k = i; k <= j; k++)
                {
                    if (arr[k] < min1)
                    {
                        min2 = min1;
                        min1 = arr[k];
                    }
                    else if (arr[k] < min2)
                    {
                        min2 = arr[k];
                    }
                    sum = min1 + min2;
                }
                max = Math.Max(sum, max);
            }
        }
        return max;
    }

    //Buy and sell stocks 
    //My soln
    public int buySellStocks(int[] arr)
    {
        int n = arr.Length;
        int profit = 0, min = arr[0], maxProfit = 0;
        for (int i = 0; i < n; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
            maxProfit = Math.Max(profit, maxProfit);
        }
        return profit;
    }

    //Striver Soln
    public int buySellStocks1(int[] prices)
    {
        int n = prices.Length;
        int profit = 0, min = prices[0];
        for (int i = 1; i < n; i++)
        {
            int cost = prices[i] - min;
            profit = Math.Max(profit, cost);
            min = Math.Min(prices[i], min);
        }
        return profit;
    }

    //Rearrage positive and negative
    //Brute solution -> TC=O(2n) ,SC=O(n)
    public int[] rearrange1(int[] arr)
    {
        int n = arr.Length;
        List<int> positive = new List<int>();
        List<int> negative = new List<int>();
        for (int i = 0; i < n; i++)
        {
            if (arr[i] > 0)
            {
                positive.Add(arr[i]);
            }
            else
                negative.Add(arr[i]);
        }
        for (int i = 0; i < n / 2; i++)
        {
            arr[2 * i] = positive[i];
            arr[(2 * i) + 1] = negative[i];
        }
        return arr;
    }

    //Optimal Soln
    public int[] RearrangeArray(int[] nums)
    {
        int n = nums.Length;
        int[] ans = new int[n];
        int posIndex = 0, negIndex = 1;
        for (int i = 0; i < n; i++)
        {
            if (nums[i] < 0)
            {
                ans[negIndex] = nums[i];
                negIndex += 2;
            }
            else
            {
                ans[posIndex] = nums[i];
                posIndex += 2;
            }
        }
        return ans;
    }

    public int[] RearrangeArrayVar2(int[] arr)
    {
        int n = arr.Length;
        List<int> positive = new List<int>();
        List<int> negative = new List<int>();
        for (int i = 0; i < n; i++)
        {
            if (arr[i] > 0)
            {
                positive.Add(arr[i]);
            }
            else
                negative.Add(arr[i]);
        }
        if (positive.Count > negative.Count)
        {
            for (int i = 0; i < negative.Count; i++)
            {
                arr[2 * i] = positive[i];
                arr[(2 * i) + 1] = negative[i];
            }
            int index = negative.Count * 2;
            for (int i = negative.Count; i < positive.Count; i++)
            {
                arr[index] = positive[i];
                index++;
            }

        }
        else
        {
            for (int i = 0; i < positive.Count; i++)
            {
                arr[2 * i] = positive[i];
                arr[(2 * i) + 1] = negative[i];
            }
            int index = negative.Count * 2;
            for (int i = positive.Count; i < negative.Count; i++)
            {
                arr[index] = negative[i];
                index++;
            }
        }
        return arr;
    }

    //Next Permutation
    //Optimized
    //TC=(3N) SC=(1)
    public void NextPermutation(int[] nums)
    {
        int n = nums.Length;
        int ind = -1;
        //Find the dipping point
        for (int i = n - 2; i >= 0; i--)
        {
            if (nums[i] < nums[i + 1])
            {
                ind = i;
                break;
            }
        }
        if (ind == -1)
        {
            Array.Reverse(nums);
            return;
        }
        //find the next smallest 
        for (int i = n - 1; i > ind; i--)
        {
            //swap
            if (nums[i] > nums[ind])
            {
                int temp = nums[i];
                nums[i] = nums[ind];
                nums[ind] = temp;
                break;
            }
        }
        // array reverse or sort 
        Array.Reverse(nums, ind + 1, n - ind - 1);
    }

    //brute for Leader in an array problem
    public List<int> LeaderInanArray(int[] arr)
    {
        List<int> Leaderlist = new List<int>();
        int n = arr.Length;

        for (int i = 0; i < n; i++)
        {
            bool IsLeader = true;
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] > arr[i])
                {
                    IsLeader = false;
                    break;
                }
            }
            if (IsLeader)
                Leaderlist.Add(arr[i]);
        }
        return Leaderlist;
    }

    //Optimal Solution for Leaders in an array
    public List<int> Leader2(int[] arr)
    {
        int n = arr.Length;
        int max = int.MinValue;
        List<int> leader = new List<int>();
        for (int i = n - 1; i >= 0; i--)
        {
            if (arr[i] > max)
            {
                leader.Add(arr[i]);
            }
            max = Math.Max(max, arr[i]);
        }
        leader.Sort();//or leader.Reverse();
        return leader;
    }

    //Longest subsequence in an array 
    //Brute solution
    //TC=O(n^2) SC=O(1)
    public static int longestSubsequence(int[] arr)
    {
        int n = arr.Length;
        int longest = 1;
        for (int i = 0; i < n; i++)
        {
            int x = arr[i];
            int count = 1;
            while (ls(arr, x + 1)) //using ls
            {
                x = x + 1;
                count += 1;
            }
            //while (Array.Exists(arr,val=>val==x+1))//using predicates
            //{
            //    x = x + 1;
            //    count += 1;
            //}
            longest = Math.Max(longest, count);
        }

        return longest;
    }
    public static bool ls(int[] arr, int num)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == num)
            {
                return true;
            }
        }
        return false;
    }

    //Better Soln
    public int longestsubsequence1(int[] arr)
    {
        //first sort 
        Array.Sort(arr);
        int n = arr.Length;
        int longest = 1, count = 0;
        int lastsmallest = int.MinValue;
        for (int i = 0; i < n; i++)
        {
            if (arr[i] - 1 == lastsmallest)
            {
                count += 1;
                lastsmallest = arr[i];
            }
            else if (lastsmallest != arr[i])
            {
                count = 1;
                lastsmallest = arr[i];
            }
            longest = Math.Max(longest, count);
        }
        return longest;

    }

    //Optimal solution

    public int longestsubsequence(int[] arr)
    {
        int n = arr.Length;
        int longest = 1;
        if (n == 0) return n;
        HashSet<int> value = new HashSet<int>();
        for (int i = 0; i < n; i++) //Push it to the List 
        {
            value.Add(arr[i]);
        }
        foreach (int val in value)
        {
            if (!value.Contains(val - 1)) //if value less than the current value is not available then only proceed else dont proceed 
            {
                int cnt = 1;
                int x = val;
                while (value.Contains(x + 1))//Checks the count 
                {
                    x = x + 1;
                    cnt += 1;
                }
                longest = Math.Max(longest, cnt);
            }
        }
        return longest;
    }

    //Set matrix to Zero
    //Brute 
    //TC=O(3N),SC=O(n)
    public int[,] setMatrixZero(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] == 0)
                {
                    makeRowz(matrix, i, m);
                    makeColumnz(matrix, j, n);
                }
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] == -1)
                {
                    matrix[i, j] = 0;
                }
            }
        }
        return matrix;
    }

    public void makeRowz(int[,] matrix, int rowIndex, int cols)
    {
        for (int j = 0; j < cols; j++)
        {
            matrix[rowIndex, j] = -1;
        }
    }
    public void makeColumnz(int[,] matrix, int colIndex, int rows)
    {
        for (int i = 0; i < rows; i++)
        {
            matrix[i, colIndex] = -1;
        }
    }

    //Brute Solution
    //TC=O(2*n*m) SC=O(n)+o(m)
    public int[,] setmatrixZero1(int[,] matrix)
    {
        int n = matrix.GetLength(0);
        int m = matrix.GetLength(1);
        //create a row size array and column size array
        int[] row = new int[n];
        int[] col = new int[m];
        //Go throught the matrix and find the zeros and mark row and colmn array
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (matrix[i, j] == 0)
                {
                    row[i] = 1;
                    col[j] = 1;
                }
            }
        }
        //Change all the column and row array which is marked 
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                if (row[i] == 1 || col[j] == 1)
                {
                    matrix[i, j] = 0;
                }
            }
        }

        return matrix;
    }

    //Optimal 
    //TC=O(n*m)
    //SC=O(1)
    public void SetZeroes(int[][] matrix)
    {
        //int[] col = matrix[0][...];
        //int[] row = matrix[..][0];
        int col0 = 1;
        int n = matrix.Length;
        int m = matrix[0].Length;
        for (int i = 0; i < n; i++)//mark all the row and column if 0 is present 
        {
            if (matrix[i][0] == 0) col0 = 0;
            for (int j = 1; j < m; j++)
            {

                if (matrix[i][j] == 0)
                {
                    matrix[i][0] = 0;
                    matrix[0][j] = 0;
                }
            }
        }
        //Convert the row and column to 0 skipping 0th row and 0th column
        for (int i = 1; i < n; i++)
        {
            for (int j = 1; j < m; j++)
            {
                if (matrix[i][j] != 0)
                {
                    if (matrix[i][0] == 0 || matrix[0][j] == 0)
                    {
                        matrix[i][j] = 0;
                    }
                }
            }
        }
        //now convert row and column 
        //first convert column
        if (matrix[0][0] == 0)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[0][j] = 0;
            }
        }
        if (col0 == 0)
        {
            for (int i = 0; i < n; i++)
            {
                matrix[i][0] = 0;
            }
        }
    }

    //Rotate Array by 90degrees
    //Brute Solution
    //TC=O(n^2)  SC =O(n^2)
    public void Rotate90(int[][] matrix)
    {
        int n = matrix.Length;
        int m = matrix[0].Length;

        int[][] ans = new int[m][];
        for (int i = 0; i < m; i++)
        {
            ans[i] = new int[n];
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                ans[j][n - 1 - i] = matrix[i][j];
            }
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i][j] = ans[i][j];
            }
        }
    }

    //optimal soln
    public void Rotate90P2(int[][] matrix)
    {
        int n = matrix.Length;
        int m = matrix[0].Length;

        //Transpose -- Convert row-> Column
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                //swap
                int temp = matrix[i][j];
                matrix[i][j] = matrix[j][i];
                matrix[j][i] = temp;
            }
        }
        //Reverse a matrix row 
        for (int i = 0; i < n; i++)
        {
            Array.Reverse(matrix[i]);
        }
    }

    //Print Matrix in spiral 
    //Only Optimal soln
    //TC = O(n*m) , SC=O(n*m)
    public IList<int> spiral(int[][] matrix)
    {
        int n = matrix.Length;
        int m = matrix[0].Length;
        int left = 0, right = m - 1, bottom = n - 1, top = 0;
        IList<int> list = new List<int>();
        //right
        for (int i = left; i <= right; i++) { list.Add(matrix[top][i]); }
        top++;
        //bottom
        for (int i = top; i <= bottom; i++) { list.Add(matrix[i][right]); }
        right--;
        //left 
        if (top <= bottom)
        {
            for (int i = right; i <= left; i--) { list.Add(matrix[bottom][i]); }
            bottom--;

        }
        //top
        if (left <= right)
        {
            for (int i = bottom; i <= top; i--) { list.Add(matrix[left][i]); }
            left++;
        }
        return list;
    }

    //Pascal Triangle Type 1 Problem =Find the Element in row, column place -->Find using nCr formula
    //TC = O(r), SC = O(1)
    public int pascaltri1(int row, int col)
    {
        int result = resultant(row - 1, col - 1);
        return result;
    }
    public int resultant(int n, int r) //formula nCr = n!/r!*(n-r)!
    {
        int res = 1;
        for (int i = 0; i < r; i++)
        {
            res = res * (n - i);
            res = res / i + 1;
        }
        return res;
    }

    //Pascal Triangle Type 2 Problem = Print the row elemnt for the given row number
    //TC=O(n) SC=O(1)
    public void pascaltri2(int n)
    {
        int ans = 1;
        Console.WriteLine(ans);
        for (int i = 0; i < n; i++)
        {
            ans = ans * (n - i);
            ans = ans / i;
            Console.WriteLine(ans);
        }
    }

    //Pascal Triangle Type 3 Problem = Create a Pascal triangle for the given number of n rows
    public IList<IList<int>> GeneratePascal(int N)
    {
        IList<IList<int>> ansList = new List<IList<int>>();
        for (int i = 0; i < N; i++)
        {
            ansList.Add(GenerateRow(i));
        }
        return ansList;
    }

    public IList<int> GenerateRow(int row)
    {
        int ans = 1;
        IList<int> list = new List<int>();
        list.Add(ans);
        for (int col = 1; col < row; col++)
        {
            ans = ans * (row - col);
            ans = ans * (col);
            list.Add(ans);
        }
        return list;
    }

    //Majority n/3 times
    //Brute Soln = TC =O(n^3) SC=O(n)
    public List<int> Majn3(int[] arr)
    {

        int n = arr.Length;
        int min = (n / 3) + 1;
        List<int> list = new List<int>();
        for (int i = 0; i < n - 1; i++)
        {
            int count = 0;

            if (list.Count != 0 || list[0] != arr[i])
            {
                for (int j = 0; j < n - 1; j++)
                {
                    if (arr[i] == arr[j]) count++;
                }
                if (count > min)
                {
                    list.Add(arr[i]);
                    break;
                }
            }

        }
        return list;
    }

    //Better Soln
    //TC= O(nLogn) SC=O(n)
    public IList<int> Majn3B(int[] arr)
    {
        int n = arr.Length;
        int min = (n / 3) + 1;
        Dictionary<int, int> map = new Dictionary<int, int>();
        IList<int> list = new List<int>();
        for (int i = 0; i < n - 1; i++)
        {
            if (!map.ContainsKey(arr[i]))
            {
                map[arr[i]] = 1;
            }
            else
                map[arr[i]]++;

            if (map[arr[i]] == min)
            {
                list.Add(arr[i]);
            }
        }
        return list;
    }

    //Optimal Soln 
    public IList<int> Mah3O(int[] nums)
    {
        int n = nums.Length;
        int cnt1 = 0, cnt2 = 0, ele1 = int.MinValue, ele2 = int.MinValue;
        IList<int> list = new List<int>();
        for (int i = 0; i < n; i++)
        {
            if (cnt1 == 0 && nums[i] != ele2)
            {
                cnt1 = 1;
                cnt1 = nums[i];
            }
            else if (cnt2 == 0 && nums[i] != ele1)
            {
                cnt2 = 1;
                cnt2 = nums[i];
            }
            else if (ele1 == nums[i]) { cnt1++; }
            else if (ele2 == nums[i]) { cnt2++; }
            else
                cnt1--;
            cnt2--;
        }
        //manually check whether the element are there or not and return 
        int cntn1 = 0, cntn2 = 0;
        for (int i = 0; i < n; i++)
        {
            if (ele1 == nums[i])
            {
                cntn1++;
            }
            if (ele2 == nums[i])
            {
                cntn1++;
            }
            int min = (n / 3) + 1;
            if (ele1 >= min) list.Add(nums[i]);
            if (ele2 >= min) list.Add(nums[i]);

        }
        return list;
    }

    //3Sum problem
    //It will not run because Its Time complexity is too much 
    //TC = O(n^3 + log(number of elements)) SC =2(no of element in triplets)
    public IList<IList<int>> ThreeSum(int[] arr)
    {
        int n = arr.Length;
        IList<IList<int>> list = new List<IList<int>>();
        HashSet<List<int>> set = new HashSet<List<int>>();
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                for (int k = j + 1; k < n; k++)
                {
                    if (arr[i] + arr[j] + arr[k] == 0)
                    {
                        List<int> triplet = new List<int> { arr[i], arr[j], arr[k] };
                        triplet.Sort();
                        set.Add(triplet);
                    }
                }
            }
        }
        foreach (var triplets in set)
        {
            list.Add(triplets);
        }

        return list;
    }

    //Better
    //TC=O(n^2 log M) where M-> Size of array , SC=O(n) 
    public IList<IList<int>> ThreeSumBetter(int[] nums)
    {
        HashSet<string> set = new HashSet<string>();
        int n = nums.Length;
        IList<IList<int>> ans = new List<IList<int>>();
        for (int i = 0; i < n; i++)
        {
            HashSet<int> Hashset = new HashSet<int>();
            for (int j = i + 1; j < n; j++)
            {
                int third = -(nums[i] + nums[j]);
                if (Hashset.Contains(third))
                {
                    List<int> list = new List<int> { nums[i], nums[j], third };
                    list.Sort();
                    string key = string.Join(",", list);
                    if (!set.Contains(key))
                    {
                        set.Add(key);
                        ans.Add(list);
                    }
                }
                Hashset.Add(nums[j]);
            }
        }

        return ans;
    }

    //Optimal - Using Two Pointer Approach 
    //TC=O(nlogn +n*n) SC= O(no of nums)
    public IList<IList<int>> ThreeSumOptimal(int[] nums)
    {
        IList<IList<int>> ans = new List<IList<int>>();
        int n = nums.Length;
        Array.Sort(nums);

        for (int i = 0; i < n; i++)
        {

            if (i > 0 && nums[i] == nums[i - 1]) continue; //skip duplicates for i
            int j = i + 1, k = n - 1;
            while (j < k)
            {
                int sum = nums[i] + nums[j] + nums[k];
                if (sum < 0) j++;
                else if (sum > 0) k--;
                else
                {
                    IList<int> list = new List<int> { nums[i], nums[j], nums[k] };
                    j++;
                    k--;
                    //skip duplicates for j and k
                    while (j < k && nums[j] == nums[j - 1]) j++;
                    while (j < k && nums[k] == nums[k + 1]) k--;
                    ans.Add(list);
                }
            }

        }
        return ans;
    }

    //4 SUM Problem
    //Brute Solution
    //TC=n^4 SC=O(no of quads)*2
    public IList<IList<int>> fourSumOptimal(int[] nums, int target)
    {
        IList<IList<int>> ans = new List<IList<int>>();
        HashSet<List<int>> set = new HashSet<List<int>>();
        int n = nums.Length;
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                for (int k = j + 1; k < n; k++)
                {
                    for (int l = k + 1; k < n; k++)
                    {
                        long sum = nums[i] + nums[j];
                        sum += nums[k];
                        sum += nums[l];
                        if (sum == target)
                        {
                            List<int> list = new List<int> { nums[i], nums[j], nums[k], nums[l] };
                            list.Sort();
                            set.Add(list);
                        }
                    }
                }
            }
        }
        foreach (var li in set)
        {
            ans.Add(li);
        }
        return ans;
    }

    //Better soln 
    //TC = n^3 log n SC=O(n) and O(no of quads)*2
    public IList<IList<int>> fourSumBetter(int[] nums, int target)
    {
        int n = nums.Length;
        HashSet<int> set = new HashSet<int>();
        HashSet<List<int>> lset = new HashSet<List<int>>();
        IList<IList<int>> ans = new List<IList<int>>();
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                for (int k = j + 1; k < n; k++)
                {
                    long sum = nums[i] + nums[j] + nums[k];
                    int fourth = target - (((int)sum));
                    if (set.Contains(fourth))
                    {
                        List<int> list = new List<int> { nums[i], nums[j], nums[k], fourth };
                        lset.Add(list);
                    }
                }
            }
        }
        foreach (var li in lset)
        {
            ans.Add(li);
        }
        return ans;
    }

    //Optimal Solution ~ to 3 Sum
    //Tc O(n^3) SC=O(no of qurds) using to return the problem 
    public IList<IList<int>> FourSum(int[] nums, int target)
    {
        IList<IList<int>> ans = new List<IList<int>>();
        int n = nums.Length;
        Array.Sort(nums);
        for (int i = 0; i < n; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1]) continue;
            for (int j = i + 1; j < n; j++)
            {
                if (j != (i + 1) && nums[j] == nums[j - 1]) continue;

                int k = j + 1, l = n - 1;
                while (k < l)
                {
                    long sum = nums[i] + nums[j];
                    sum += nums[k];
                    sum += nums[l];

                    if (sum == target)
                    {
                        List<int> list = new List<int> { nums[i], nums[j], nums[k], nums[l] };
                        ans.Add(list);
                        k++; l--;
                        while (k < l && nums[k] == nums[k - 1]) k++;
                        while (k < l && nums[l] == nums[l + 1]) l--;
                    }
                    else if (sum < target) k++;
                    else l--;
                }
            }

        }
        return ans;

    }

    //Longest subarray equals sum =0 
    //Brute Soln 
    //TC = O(n^3) SC =O(1)
    public int LongestSubarrayzeroB(int[] arr)
    {
        int n = arr.Length;
        int sum = 0, length = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                for (int k = i; k < j; k++)
                {
                    sum += arr[k];
                    if (arr[k] == 0)
                    {
                        length = Math.Max(length, j - i + 1);
                    }
                }
            }
        }
        return length;
    }

    //In Better Soln remove k loop so that TC=O(n^2) SC =O(1)

    //Optimal soln 
    //TC=O(Nlogn) SC=(1)
    public int LongestSubarrayzero(int[] arr)
    {
        int n = arr.Length;
        Dictionary<int, int> map = new Dictionary<int, int>();//prefixsum ,Index
        int length = 0, prefixSum = 0;
        for (int i = 0; i < n; i++)
        {
            prefixSum += arr[i];
            if (prefixSum == 0)
            {
                length = Math.Max(length, i + 1);
            }
            else if (map.ContainsKey(prefixSum))
            {
                length = Math.Max(length, i - map[prefixSum]);
            }
            else
            {
                map[prefixSum] = i;
            }
        }
        return length;
    }

    //Longest subarray equals Xor  
    //Brute Soln 
    //TC = O(n^3) SC =O(1)
    public int LongestSubarrayXorB(int[] arr, int res)
    {
        int n = arr.Length;
        int sum = 0, length = 0, Xor = 0, cnt = 0; ;
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                Xor = Xor ^ arr[j];
                if (Xor == res)
                {
                    cnt++;
                }
            }
        }
        return cnt;
    }

    //TC=O(n) SC=O(nlogn)
    public int LongestSubarrayXoRO(int[] arr, int k)
    {
        int n = arr.Length;
        int Xor = 0, cnt = 0;
        Dictionary<int, int> map = new Dictionary<int, int>();
        map[Xor]++;//{0,1}
        for (int i = 0; i < n; i++)
        {
            Xor = Xor ^ arr[i];
            int x = Xor ^ k;
            cnt += map[x];
            map[Xor]++;

        }
        return cnt;
    }

    //Merge Overlapping SubIntervals
    //TC = O(2N)+nlogn SC=(n)
    public int[][] Merge(int[][] intervals)
    {
        int n = intervals.Length;
        if (intervals == null || intervals.Length == 0)
            return new int[0][];

        // Sort intervals by start time
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));

        List<int[]> merged = new List<int[]>();
        for (int i = 0; i < n; i++)
        {
            int start = intervals[i][0];
            int end = intervals[i][1];
            if (merged.Count != 0 && end <= merged[merged.Count - 1][1])//end = (1,6),mergent.Count-1= back ->(6) =>{2,4}{1,6} if 4<=6
            {
                continue;
            }
            for (int j = i + 1; j < n; j++)
            {
                //overlapping check 
                if (intervals[j][0] <= end)
                {
                    end = Math.Max(end, intervals[j][1]);
                }
                else break;
            }
            merged.Add(new int[] { start, end });
        }
        return merged.ToArray();
    }

    //Optimal Soln
    public int[][] MergeOptimal(int[][] intervals)
    {
        int n = intervals.Length;
        Array.Sort(intervals, (a, b) => a[0].CompareTo(b[0]));
        List<int[]> ans = new List<int[]>();
        for (int i = 0; i < n; i++)
        {
            //if the list is empty
            if (ans.Count == 0 || intervals[i][0] > ans[ans.Count - 1][1])
            {
                ans.Add(intervals[i]);
            }
            //push the overlapping intervals in the array
            else
            {
                ans[ans.Count - 1][1] = Math.Max(ans[ans.Count - 1][1], intervals[i][1]);
            }
        }
        return ans.ToArray();

    }

    //Merge 2 Sorted Array without extra space 
    public void MergeArrays(int[] nums1, int m, int[] nums2, int n)
    {
        int left = m - 1, right = 0;
        while (left >= 0 && right < n)
        {
            if (nums1[left] > nums2[right])
            {
                int temp = nums1[left];
                nums1[left] = nums2[right];
                nums2[right] = temp;
                left--;
                right++;
            }
            else
            {
                break;
            }
        }
        Array.Sort(nums1, 0, m);
        Array.Sort(nums2);
        // Step 3: Copy nums2 to the tail of nums1
        for (int i = 0; i < n; i++)
        {
            nums1[m + i] = nums2[i];
        }

    }

    public void gapMethodMerge(int[] nums1, int[] nums2)
    {
        int n = nums1.Length;
        int m = nums2.Length;
        int len = n + m;
        int gap = (len / 2) + (len % 2);
        while (gap > 0)
        {
            int left = 0;
            int right = left + gap;
            while (right < len)
            {
                //three condition 
                //1st -> left pointer on left array and right pointer on right array
                if (left < n && right >= n)
                {
                    swap(nums1, nums2, left, right - n);
                }
                //2nd -> left pointer on right and right pointer is on right 
                if (left >= n)
                {
                    swap(nums2, nums2, left - n, right);
                }
                else
                {
                    swap(nums1, nums1, left, right);
                }
                left++;
                right++;
            }
            if (gap == 1) break;
            gap = (gap / 2) + (gap % 2);//reduce the gap and seal it if it is odd
        }
    }

    //method to swap left >right
    public void swap(int[] arr1, int[] arr2, int ind1, int ind2)
    {
        if (arr1[ind1] > arr2[ind2])
        {
            int temp = arr1[ind1];
            arr1[ind1] = arr2[ind2];
            arr2[ind2] = temp;
        }
    }

    //Find the Missing and repeating numbers 
    //Brute TC=O(n^2) SC=(1)
    public int[] MissandRepNum(int[] arr)
    {
        int n = arr.Length;
        int count = 0, missingNum = -1, RepeatingNum = -1;

        for (int i = 1; i <= n; i++)
        {
            count = 0;
            for (int j = 0; j < n; j++)
            {
                if (arr[j] == i) count++;
            }
            if (count == 2) RepeatingNum = i;
            if (count == 0) missingNum = i;

            if (RepeatingNum != -1 && missingNum != -1)
            {
                break;
            }
        }

        return new int[] { RepeatingNum, missingNum };
    }

    //Better Soln
    //TC=O(2n), SC=O(n)
    public int[] MissAndRepNumB(int[] arr)
    {
        int n = arr.Length;
        int[] hasharr = new int[n + 1];
        for (int i = 0; i < n; i++)
        {
            hasharr[arr[i]]++;
        }
        int repNum = -1, missNum = -1;
        for (int i = 0; i < n; i++)
        {
            if (hasharr[i] == 2) repNum = i;
            else if (hasharr[i] == 0) missNum = i;
            if (repNum == -1 && missNum == -1) break;
        }
        return new int[] { repNum, missNum };
    }

    //Optimal
    //Mathematical soln
    //TC=O(n),SC=O(n)
    public int[] MissAndRepNumO(int[] arr)
    {
        int n = arr.Length;
        long SumN = 0, SumAN = 0, SumNN = 0, SumANN = 0;
        SumN = n * (n + 1) / 2;
        SumNN = n * (n + 1) * (2 * n + 1) / 6;
        for (int i = 0; i < n; i++)
        {
            SumAN += arr[i];
            SumANN += arr[i] * arr[i];
        }
        long val1 = SumAN - SumN;//x-y
        long val2 = SumANN - SumNN;
        val2 = val2 / val1;//x+y
        long x = (val1 + val2) / 2;
        long y = x - val1;
        return new int[] { (int)x, (int)y };

    }


    #region //Count Inversion
    //Count Inversion in an array -->return number of pairs where arr[i]>arr[j]
    //Brute TC=O(n^2) SC=O(1)
    public int CountInversionB(int[] arr)
    {
        int n = arr.Length;
        int cnt = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (arr[i] > arr[j]) cnt += 1;
            }
        }
        return cnt;
    }
    //Optimal- Using Merge Sort
    //TC = O(nLogn) SC=O(n)
    //Merge Sort algo
    public int MergeI(int[] arr, int low, int middle, int high)
    {
        List<int> temp = new List<int>();
        int left = low;
        int right = middle + 1;
        int cnt = 0;
        while (left <= middle && right <= high)
        {

            if (arr[left] <= arr[right])
            {
                temp.Add(arr[left]);
                left++;
            }
            else//right is smaller 
            {
                temp.Add(arr[right]);
                cnt += (middle - left + 1);
                right++;
            }

        }
        while (left <= middle)
        {
            temp.Add(arr[left]);
            left++;

        }
        while (right <= high)
        {
            temp.Add(arr[right]);
            right++;
        }

        //put back in an original array from temp
        for (int i = low; i <= high; i++)
        {
            arr[i] = temp[i - low];
        }
        return cnt;
    } //Here we need to convey that we are alering the data
    public int MergeSort2I(int[] arr, int low, int high) //5, 4, 6, 2, 3, 5, 6  // Time Complexity = N log base 2 n
    {
        int cnt = 0;
        if (low == high) return cnt;
        int n = arr.Length;
        int middle = (low + high) / 2;
        cnt += MergeSort2I(arr, low, middle);
        cnt += MergeSort2I(arr, middle + 1, high);
        cnt += MergeI(arr, low, middle, high);
        return cnt;

    }
    public int CountInversionO(int[] arr)
    {
        int n = arr.Length;
        return MergeSort2I(arr, 0, n - 1);
    }
    #endregion

    #region //Reverse pair

    //Reverse Pair -->return number of pairs where arr[i]>2*arr[j]
    //TC=O(2nlogn) SC=O(n)
    public int countPairs(int[] arr, int low, int mid, int high)
    {
        int cnt = 0;
        int right = mid + 1;
        for (int i = low; i <= mid; i++)
        {
            while (right <= high && (long)arr[i] > 2L * arr[right])
            {
                right++;
            }
            cnt = cnt + (right - (mid + 1));
        }

        return cnt;
    }
    public int MergeSort2R(int[] arr, int low, int high) //5, 4, 6, 2, 3, 5, 6  // Time Complexity = N log base 2 n
    {
        int cnt = 0;
        if (low == high) return cnt;
        int n = arr.Length;
        int middle = (low + high) / 2;
        cnt += MergeSort2R(arr, low, middle);//count got while splitted time
        cnt += MergeSort2R(arr, middle + 1, high);//count got while spliited time
        cnt += countPairs(arr, low, middle, high);
        MergeR(arr, low, middle, high);
        return cnt;

    }
    public void MergeR(int[] arr, int low, int middle, int high)
    {
        List<int> temp = new List<int>();
        int left = low;
        int right = middle + 1;
        while (left <= middle && right <= high)
        {
            if (arr[left] <= arr[right])
            {
                temp.Add(arr[left]);
                left++;
            }
            else
            {
                temp.Add(arr[right]);
                right++;
            }
        }
        while (left <= middle)
        {
            temp.Add(arr[left]);
            left++;

        }
        while (right <= high)
        {
            temp.Add(arr[right]);
            right++;
        }

        //put back in an original array from temp
        for (int i = low; i <= high; i++)
        {
            arr[i] = temp[i - low];
        }


    }

    public int ReversePairs(int[] nums)
    {
        int n = nums.Length;
        int low = 0, high = n - 1;
        int cnt = MergeSort2R(nums, low, high);
        return cnt;
    }
    #endregion

    //Maximum Product in a Subarray
    //TC=O(n^2) SC=O(1)
    public int maxProdBrt(int[] arr)
    {
        int n = arr.Length;
        int maxProd = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                int prod = 1;
                for (int k = i; k <= j; k++)
                {
                    prod = prod * arr[k];
                }
                maxProd = Math.Max(maxProd, prod);
            }
        }
        return maxProd;
    }

    //Better Soln
    //TC =O(n^2) SC=O(1)
    public int maxProdBetr(int[] arr)
    {
        int n = arr.Length;
        int maxProd = int.MinValue;
        for (int i = 0; i < n; i++)
        {
            int prod = 1;
            for (int j = i; j < n; j++)
            {
                prod = prod * arr[j];
                maxProd = Math.Max(maxProd, prod);
            }

        }
        return maxProd;
    }

    //Optimal Solution 
    //TC=O(n^2) SC=O(1)
    public int maxProdOptml(int[] arr)
    {
        int n = arr.Length;
        int prefix = 1, suffix = 1, maxProd = int.MinValue;
        for (int i = 0; i < n; i++)
        {
            if (prefix == 0) prefix = 1;
            if (suffix == 0) suffix = 1;
            prefix = prefix * arr[i];
            suffix = suffix * arr[n - i - 1];
            maxProd = Math.Max(maxProd, Math.Max(prefix, suffix));
        }
        return maxProd;
    }

    #region Binary Search
    ////////////////////////////////////////////////////// -  Binary Search - //////////////////////////////////////////////
    //Iterative method
    public int BSearchLoop(int[] nums, int target)
    {
        int n = nums.Length;
        int low = 0, high = n - 1, mid = 0;
        while (low <= high)
        {
            mid = (low + high) / 2;
            if (nums[mid] == target) return mid;
            else if (nums[mid] > target) high = mid - 1;
            else low = mid + 1;
        }
        return -1;
    }

    //Recursive method
    //TC=O(log(base2)n) SC=O(1)
    public int Search(int[] nums, int target)
    {
        int n = nums.Length;
        int low = 0, high = n - 1;
        return BinarySearch(nums, low, high, target);
    }
    public int BinarySearch(int[] nums, int low, int high, int target)
    {
        if (low > high) return -1;
        int mid = (low + high) / 2;
        if (nums[mid] == target) return mid;
        else if (nums[mid] > target) return BinarySearch(nums, low, mid - 1, target);
        return BinarySearch(nums, mid + 1, high, target);
    }

    //Lower Bound
    //TC=O(log(base2)n) SC=O(1)
    public int LowerBound(int[] nums, int x)
    {
        int n = nums.Length;
        int low = 0, high = n - 1, mid = 0;
        int ans = n;
        while (low <= high)
        {
            mid = (low + high) / 2;
            if (nums[mid] >= x)
            {
                ans = mid;
                high = mid - 1;
            }
            else low = mid + 1;
        }
        return ans;
    }

    //Upper Bound
    //TC=O(log(base2)n) SC=O(1)
    public int UpperBound(int[] nums, int x)
    {
        int n = nums.Length;
        int low = 0, high = n - 1, mid = 0;
        int ans = n;
        while (low <= high)
        {
            mid = (low + high) / 2;
            if (nums[mid] > x)
            {
                ans = mid;
                high = mid - 1;
            }
            else low = mid + 1;
        }
        return ans;
    }

    //Search and Insert ~ to lower bound
    //TC=O(log(base2)n) SC=O(1)
    public int SearchandInsert(int[] nums, int x)
    {
        int n = nums.Length;
        int low = 0, high = n - 1, mid = 0;
        int ans = n;
        while (low <= high)
        {
            mid = (low + high) / 2;
            if (nums[mid] >= x)
            {
                ans = mid;
                high = mid - 1;
            }
            else low = mid + 1;
        }
        return ans;
    }

    //floor and ceil 
    //floor = largest number in an array <= x;
    public int floor(int[] nums, int x)
    {
        int n = nums.Length;
        int low = 0, high = n - 1, mid = 0;
        int ans = n;
        while (low <= high)
        {
            mid = (low + high) / 2;
            if (nums[mid] <= x)
            {
                ans = nums[mid];
                low = mid - 1;
            }
            else high = mid - 1;
        }
        return ans;
    }

    //ceil = smallest number in an array >= x;-->lower bound (here need to return the number not index)
    public int ceil(int[] nums, int x)
    {
        int n = nums.Length;
        int low = 0, high = n - 1, mid = 0;
        int ans = n;
        while (low <= high)
        {
            mid = (low + high) / 2;
            if (nums[mid] >= x)
            {
                ans = nums[mid];
                high = mid - 1;
            }
            else low = mid + 1;
        }
        return ans;
    }

    //First and Last Occurances
    //Brute TC=O(n)
    public int[] fandloccurance(int[] nums, int x)
    {
        int n = nums.Length;
        int first = -1, last = -1;
        for (int i = 0; i < n; i++)
        {
            if (nums[i] == x)
            {
                first = i;
            }
            last = i;
        }
        return new int[] { first, last };
    }

    //Binary Search using lower and upper bound 
    //TC =2*(log(base2)n)
    public int[] SearchRange(int[] nums, int target)
    {
        int n = nums.Length;
        int lb = LowerBound(nums, target);
        int ub = UpperBound(nums, target);
        ub = ub - 1;
        if (lb >= n || nums[lb] != target)
        {
            return new int[] { -1, -1 };
        }
        else
            return new int[] { lb, ub };
    }

    //Only Binary Search
    //TC=n(logb2n)
    public int firstOccurance(int[] nums, int target)
    {
        int n = nums.Length;
        int fo = -1;
        int low = 0, high = n - 1, mid = 0;
        while (low <= high)
        {
            mid = (low + high) / 2;
            if (nums[mid] >= target)
            {
                fo = mid;
                high = mid - 1;
            }
            else low = mid + 1;
        }
        return fo;
    }
    public int LastOccurance(int[] nums, int target)
    {
        int n = nums.Length;
        int lo = -1;
        int low = 0, high = n - 1, mid = 0;
        while (low <= high)
        {
            mid = (low + high) / 2;
            if (nums[mid] >= target)
            {
                lo = mid;
                low = mid + 1;

            }
            else
                high = mid - 1;
        }
        return lo;
    }

    public Tuple<int, int> SearchRangeM2(int[] nums, int target)
    {
        int n = nums.Length;
        int first = firstOccurance(nums, target);
        if (first == -1) return new Tuple<int, int>(-1, -1);
        int last = LastOccurance(nums, target);
        return new Tuple<int, int>(first, last);
    }
    //Number of occurance
    public int countOccurance(int[] arr, int target)
    {
        int count = 0;
        Tuple<int, int> ans = SearchRangeM2(arr, target);
        if (ans.Item1 == -1) return 0;
        return ans.Item1 - ans.Item2;
    }

    //Search in Sorted Array1 (unique numbers)
    //TC=n(nlogb2n)
    public int SortedSearch(int[] arr, int target)
    {
        int n = arr.Length;
        int low = 0, high = n - 1, mid = 0;
        while (low <= high)
        {
            mid = (low + high) / 2;
            if (arr[mid] == target) return mid;
            //left sorted
            else if (arr[low] <= arr[mid])
            {
                //tell whether it lies between low to mid
                if (arr[low] <= target && target <= arr[mid]) high = mid - 1;
                else low = mid + 1;
            }
            //right sorted
            else
                //tell whether it lies between low to mid
                if (arr[mid] <= target && target <= arr[high]) low = mid + 1;
            else high = mid - 1;

        }
        return -1;
    }

    //Search in Sorted Array2 (duplicates)
    //TC=O(n/2)
    public bool Search2(int[] nums, int target)
    {
        int n = nums.Length;
        int low = 0, high = n - 1, mid = 0;
        while (low <= high)
        {
            mid = (low + high) / 2;
            if (nums[mid] == target) return true;
            if (nums[low] == nums[mid] && nums[mid] == nums[high])
            {
                low += 1;
                high -= 1;
                continue;
            }
            //left sorted
            if (nums[low] <= nums[mid])
            {
                //check values are present or not 
                if (nums[low] <= target && target <= nums[mid])
                {
                    high = mid - 1;
                }
                else
                    low = mid + 1;
            }
            //right sorted
            else
            {
                //check values is present or not
                if (nums[mid] <= target && target <= nums[high])
                {
                    low = mid + 1;
                }
                else
                    high = mid - 1;
            }
        }
        return false;
    }

    //Find the minimum in an rotated array
    //TC=O(nlogb2n)
    public int FindMin(int[] nums)
    {
        int n = nums.Length;
        int low = 0, high = n - 1, ans = int.MaxValue;
        while (low <= high)
        {
            int mid = (low + high) / 2;
            //if array is already sorted then take the min and break no need of further Binary search
            if (nums[low] <= nums[high])
            {
                ans = Math.Min(ans, nums[low]);
                break;
            }
            if (nums[low] <= nums[mid])
            {
                ans = Math.Min(ans, nums[low]);
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
                ans = Math.Min(ans, nums[mid]);
            }
        }
        return ans;
    }

    //Find how many times array is rotated
    //TC=O(nlogb2n)
    public int RotatedTimes(int[] nums)
    {
        int n = nums.Length;
        int low = 0, high = n - 1, ans = int.MaxValue, ind = 0;
        while (low <= high)
        {
            int mid = (low + high) / 2;
            //if array is already sorted then take the min and break no need of further Binary search
            if (nums[low] <= nums[high])
            {
                if (nums[low] < ans)
                {
                    ind = low;
                    ans = nums[low];
                }
                break;
            }
            if (nums[low] <= nums[mid])
            {
                if (nums[low] < ans)
                {
                    ind = low;
                    ans = nums[low];
                }
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
                if (nums[mid] < ans)
                {
                    ind = mid;
                    ans = nums[mid];
                }
                ind = mid;
            }
        }
        return ind;
    }

    //Find the single element in an array
    //Brute
    //TC=O(n)
    public int SingleElementB(int[] arr)
    {
        int n = arr.Length;
        int ans = 0;
        if (n == 1) return arr[0];
        //checking first element 
        if (arr[0] != arr[1]) return arr[0];
        //checking the second element 
        if (arr[n - 1] != arr[n - 2]) return arr[n - 1];

        for (int i = 1; i < n - 1; i++)
        {
            if (arr[i] != arr[i - 1] && arr[i] != arr[i + 1]) return arr[i];
        }
        return 0;
    }

    //Find the peak element =>arr[i-1]<arr[i]>arr[i+1]
    //TC=O(n)
    public int PeakElement(int[] nums)
    {
        int n = nums.Length;
        for (int i = 0; i < n; i++)
        {
            if (i == 0 || nums[i] > nums[i] && i == n - 1 || nums[i] > nums[i + 1])
            {
                return i;
            }
        }
        return 0;
    }

    //Binary Search
    //TC=O(n log base2 n)
    public int FindPeakElement(int[] nums)
    {
        int n = nums.Length;
        if (n == 1) return 0;
        if (nums[0] > nums[1]) return 0;
        if (nums[n - 1] > nums[n - 2]) return n - 1;
        int low = 1, high = n - 2;
        while (low <= high)
        {
            int mid = (low + high) / 2;
            if (nums[mid] > nums[mid - 1] && nums[mid] > nums[mid + 1])
            {
                return mid;
            }
            else if (nums[mid] > nums[mid - 1]) low = mid + 1;
            else high = mid - 1;
        }
        return -1;
    }

    public int sqrtofn(long n)
    {
        long low = 1, high = n;
        while (low <= high)
        {
            long mid = (low + high) / 2;
            long val = mid * mid;
            if (val >= high) high = mid - 1;
            else low = mid + 1;
        }
        return (int)high;
    }

    //return 1 if ==mid
    //return 0 if <mid
    //return 2 if >mid
    public int multi(int mid, int n, int m)
    {
        long ans = 1;
        for (int i = 1; i <= n; i++)
        {
            ans = ans * mid;
            if (ans > m) return 2;
        }
        if (ans == mid) return 1;
        return 0;
    }
    //TC=O(nlog(base2)N*nlodb2n)
    public int nRootofm(int n, int m)
    {
        int low = 1, high = m;
        while (low <= high)
        {
            int mid = (low + high) / 2;
            if (multi(mid, n, m) == 1) return mid;
            else if (multi(mid, n, m) == 2) high = mid - 1;
            else low = mid + 1;
        }
        return -1;
    }

    //koko eating banana
    //Brute solution
    public int kokoprobBrute(List<int> piles, int h)
    {
        int maxInteger = largest(piles);
        int timetaken = 0;
        for (int i = 0; i < maxInteger; i++)
        {
            timetaken = timet(piles, i);
            if (timetaken <= h) break;
        }
        return timetaken;
    }

    public int timet(List<int> arr, int i)
    {
        int timetaken = 0;
        int n = arr.Count;
        for (int j = 0; j < n; j++)
        {
            timetaken = arr[j] / i;
        }
        return timetaken;
    }


    //Binary Search

    //Maximum number in an array
    public int MaxInteger(int[] arr)
    {
        int max = int.MinValue;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > max)
                max = arr[i];
        }
        return max;
    }

    public int timetak(int[] arr, int mid)
    {
        int timetaken = 0;
        int n = arr.Length;
        for (int j = 0; j < n; j++)
        {
            timetaken += (int)Math.Ceiling((double)arr[j] / (double)mid);
        }
        return timetaken;
    }

    public int kokoeatingBanana(int[] piles, int h)
    {
        int low = 1, high = MaxInteger(piles), timetaken = 0;
        while (low <= high)
        {
            int mid = (low + high) / 2;
            timetaken = timetak(piles, mid);
            if (timetaken <= h) high = mid - 1;
            else low = mid;
        }
        return low;
    }


    //No of days required to make m bouqets for k adjacent days 
    //Brute TC=O(max-min)*N
    public bool porOrNot(int[] bloomdays, int day, int m, int k)
    {
        int n = bloomdays.Length;
        int cnt = 0, noofbouquets = 0;
        for (int i = 0; i < n - 1; i++)
        {
            if (bloomdays[i] <= day)
            {
                cnt++;
            }
            else
            {
                noofbouquets += (cnt / k);
                cnt = 0;
            }
        }
        noofbouquets += (cnt / k);
        if (noofbouquets == k) return true;
        else return false;
    }
    public int minbloomday(int[] bloomsday, int m, int k)
    {
        int n = bloomsday.Length;
        int min = 0, max = MaxInteger(bloomsday);
        if ((m * n) < k) return -1;
        for (int i = min; i <= max; i++)
        {
            if (porOrNot(bloomsday, i, m, k))
            {
                return i;
            }
        }
        return -1;
    }

    //Optimal binary Search
    //TC=O(N * (nlog base2 (max-min)))
    public int minbloomdaybs(int[] bloomsday, int m, int k)
    {
        int n = bloomsday.Length;
        long val = (m * 1L * k * 1L);
        if (val > n) return -1;
        int low = FindMin(bloomsday), high = MaxInteger(bloomsday);
        while (low <= high)
        {
            int mid = (low + high) / 2;
            if (porOrNot(bloomsday, mid, m, k) == true)
            {
                high = mid - 1;
            }
            else low = mid + 1;
        }
        return low;
    }

    //Find the smallest divisor
    //Brute solution TC=O(N)
    public int smallestDivisorB(int[] arr, int t)
    {
        int n = arr.Length;
        int max = MaxInteger(arr), sum = 0;
        for (int i = 1; i < max; i++)
        {
            for (int j = 0; j < n - 1; j++)
            {
                sum += (int)Math.Ceiling((double)arr[j] / i);
                if (sum <= t) return i;
            }

        }
        return -1;
    }

    //Binary Search - Optimal
    //TC=O(lod base 2 * N) SC=O(1)
    public int sumOfdiv(int[] arr, int m)
    {
        int n = arr.Length;
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += (int)Math.Ceiling((double)arr[i] / (double)m);
        }
        return sum;
    }
    public int smallestDivisor(int[] nums, int t)
    {
        int n = nums.Length;
        if (n > t) return -1;
        int low = 1, high = MaxInteger(nums);
        while (low <= high)
        {
            int mid = (low + high) / 2;
            if (sumOfdiv(nums, mid) <= t) high = mid - 1;
            else low = mid + 1;
        }
        return low;


    }

    //Least capacity to ship weights in D days
    //Brute
    public int maxcapacity(int[] weights)
    {
        int n = weights.Length;
        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            sum += weights[i];
        }
        return sum;
    }
    public int shipProbB(int[] weights, int totaldays)
    {
        int n = weights.Length;
        int mincap = MaxInteger(weights);
        int maxcap = maxcapacity(weights);
        for (int i = mincap; i <= maxcap; i++)
        {
            int reqDays = requiredDays(weights, i);
            if (reqDays <= days) return i;
        }
        return -1;
    }
    public int requiredDays(int[] weights, int cap)
    {
        int n = weights.Length;
        int loadsum = 0, days = 1;
        for (int i = 0; i < n; i++)
        {
            if (loadsum + weights[i] > cap)
            {
                days++;
                loadsum = weights[i];
            }
            else
            {
                loadsum += weights[i];
            }
        }
        return days;
    }

    //Optimal with binary Search
    //TC=log base 2(max-sum+1)
    public int shipProb(int[] weights, int totaldays)
    {
        int low = MaxInteger(weights);
        int high = maxcapacity(weights);

        while (low <= high)
        {
            int mid = (low + high) / 2;
            if (requiredDays(weights, mid) <= totaldays)
            {
                high = mid - 1;
            }
            else low = mid + 1;
        }
        return low;
    }

    //Find the Kth missing number
    public int missingKnumB(int[] arr, int k)
    {
        int n = arr.Length;
        for (int i = 0; i < n; i++)
        {
            if (arr[i] <= k)
            {
                k++;
            }
            else break;
        }
        return k;
    }

    //Binary Search
    //O(logbase2N) SC=O(1)
    public int missingknum(int[] arr, int k)
    {
        int n = arr.Length;
        int low = 0, high = n - 1;
        while (low <= high)
        {
            int mid = (low + high) / 2;
            int missingNum = arr[mid] - (mid + 1);
            if (missingNum < k) low = mid + 1;
            else high = mid - 1;
        }
        return high + 1 + k;
        //or return low+k
    }

    public int MinInteger(int[] arr)
    {
        int n = arr.Length;
        int minNum = int.MaxValue;
        for (int i = 0; i < n; i++)
        {
            if (arr[i] < minNum)
            {
                minNum = arr[i];
            }
        }
        return minNum;
    }
    //Aggresive Cows
    public bool canPlacecow(int[] arr, int dist, int cows)
    {
        int n = arr.Length;
        int cntcows = 1, lastcow = arr[0];
        for (int i = 1; i < n; i++)
        {
            if (arr[i] - lastcow >= dist)
            {
                cntcows++;
                lastcow = arr[i];
            }
        }
        if (cntcows >= cows) return true;
        else return false;
    }
    //brute
    public int aggressiveCowsB(int[] arr, int cows)
    {
        Array.Sort(arr);
        int min = MinInteger(arr);
        int max = MaxInteger(arr);
        for (int i = 1; i < (max - min); i++)
        {
            if (canPlacecow(arr, i, cows))
            {
                continue;
            }
            else return (i - 1);
        }
        return -1;

    }

    //optimal
    //TC=n(logn)+(log base2 (arr[n-1] - arr[0]))*O(n)
    public int aggressiveCows(int[] arr, int cows) 
    {
        int n= arr.Length;
        int low = 1, high = arr[n-1] - arr[0];
        while (low <= high) 
        {
            int mid = (low + high) / 2;
            if (canPlacecow(arr, mid, cows) == true)
            {
                low = mid + 1;
            }
            else high = mid-1;
        } 
        return high;
    }


    #endregion Binary Search
}
