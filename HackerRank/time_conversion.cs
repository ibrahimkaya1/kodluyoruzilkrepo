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
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        var amOrPm = s.Substring(8);
        var hour = s.Substring(0, 2);
        var remainingTimeComponent = s.Substring(2, 6);
         if (amOrPm == "AM" && hour == "12")
        {
            hour = "00";
        }
        else if (amOrPm == "PM")
        {
            var numericHourComponent = int.Parse(hour);
            if (numericHourComponent != 12)
            {
                hour = Convert.ToString(12 + numericHourComponent);
            }
        }
        return (hour + remainingTimeComponent);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
