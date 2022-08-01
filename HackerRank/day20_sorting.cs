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



class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        // Write your code here
        BubbleSort(a);
    }
    public static void BubbleSort(List<int> list)
    {
        int temp=0;
        int numberOfSwaps=0;
        for(int i=0;i<list.Count;i++)
        {
            for(int j=0;j<list.Count-1;j++)
            {
                if(list[j]>list[j+1])
                {
                    temp = list[j];
                    list[j]=list[j+1];
                    list[j+1]=temp;
                    numberOfSwaps++;
                }
            }
        }
        Console.WriteLine($"Array is sorted in {numberOfSwaps} swaps.");
        Console.WriteLine($"First Element: {list[0]}");
        Console.WriteLine($"Last Element: {list[list.Count-1]}");
    }
}
