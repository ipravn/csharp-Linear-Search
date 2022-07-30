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
        int[] arr = { 71, 24, 13, 44, 95, 65 };
        Console.WriteLine(minimumValue(arr));
        Console.ReadKey();

    }


    static int minimumValue(int[] arr)
    {
        if (arr.Length == 0)
        {
            return -1;
        }
        int element = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {
            if (element > arr[i])
            {
                element = arr[i];   
            }
        }
        return element;
    }
