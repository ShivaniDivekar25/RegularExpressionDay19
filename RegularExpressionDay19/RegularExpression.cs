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
        public static void validEmail()          //Created email method
        {
            string pattern = "^[a-z]{3}.[a-z]{2,}@[a-z]{2}.[a-z]{2}.[a-z]{2}$";
            string[] arr = { "abc.xyz@bl.co.in" };
            TestPattern(pattern, arr);
        }
        public static void phoneNumber()          //Created phone number method
        {
            string pattern = "^[0-9]{2}[ ][0-9]{10}$";
            string[] arr = { "91 9421253907" };
            TestPattern(pattern, arr);
        }
        public static void password()          //Created passward method
        {
            string pattern = "^[A-Z]{1}[a-z]{7,}(@|#|$|&)[0-9]{1}$";
            string[] arr = { "Ajkdlabhl@7" ,"Ahaskj#kl77" };
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
