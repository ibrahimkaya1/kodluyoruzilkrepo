using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */
   
    public static void plusMinus(List<int> arr)
    {
        double p=0;
        double e=0;
        double notr=0;
        for (int i = 0; i < arr.Count; i++)
        {
           if(arr[i]>0){p=p+1;}
           else if(arr[i]<0){e=e+1;}
           else notr=notr+1;
        }
        
        Console.WriteLine(p/arr.Count);
        Console.WriteLine(e/arr.Count);
        Console.WriteLine(notr/arr.Count);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
