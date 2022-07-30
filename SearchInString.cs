// Linear Search Algorithm Using C#
// Praveen Kumar - https://github.com/ipravn/

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
        string str = "Hello World!";
        char[] arr = str.ToCharArray();
        char target = 'W';
        int Path = Liniearsearch(arr, target);
        Console.WriteLine(Path);
        Console.ReadKey();

    }

    static int Liniearsearch(char[] arr, char target)
    {
        if (arr.Length == 0)
        {
            return -1;
        }
        for (int i = 0; i < arr.Length; i++)
        { 
            int element = arr[i];
            if (element == target)
            { 
                return i;
            }
        }
        return -1;
    }

}
