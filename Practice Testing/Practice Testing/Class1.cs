﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public class MathUtils
{
    public static double Average(int a, int b)
    {
        return a + b / 2;
    }

    public static void Main(string[] args)
    {
        Console.WriteLine(Average(2, 1));
    }
}