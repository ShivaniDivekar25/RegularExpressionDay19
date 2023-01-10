﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpressionDay19
{ 
    public class RegularExpression
    {
        public static void fisrtName()          //Created first name method
        {
            string pattern = "^[A-Z]{1}[a-z]{2,}$";
            string[] arr = { "Shivani" };
            TestPattern(pattern, arr);
        }
        public static void lastName()          //Created last name method
        {
            string pattern = "^[A-Z]{1}[a-z]{2,}$";
            string[] arr = { "Divekar" };
            TestPattern(pattern, arr);
        }
        public static void TestPattern(string pattern, string[] arr)            //Created Test pattern method
        {
            foreach (string inputs in arr)
            {
                if (Regex.IsMatch(inputs, pattern))
                {
                    Console.WriteLine("{0} is valid", inputs);
                }
                else
                {
                    Console.WriteLine("{0} is invalid", inputs);
                }
            }

        }
    }
}
