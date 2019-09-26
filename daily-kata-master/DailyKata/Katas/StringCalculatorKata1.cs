using System;
using System.Collections.Generic;
using System.Text;

namespace DailyKata
{
    public class StringCalculatorKata
    {
        public static double Calculate(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }
            if (input == string.Empty)
            {
                throw new ArgumentException("this parameter has to be used", nameof(input));
            }
            
            if (WSCheck(input))
            {
                throw new ArgumentException("I'm a whitespace string", nameof(input));
            }
            if (isNegativeKostyli(input))
            {
                throw new ArgumentException("Negative numbers not supported", nameof(input));
            }

            double res = 0;
            string[] arr = OnlyInt(input).Split(',');
            foreach (string a in arr)
            {
                double parsed;
                if (double.TryParse(a, out parsed))
                {
                    if (parsed >= 0)
                    {
                        res += parsed;
                        Console.WriteLine(res);
                    }
                }

            }
            return res;
        }

        public static string OnlyInt(string input)
        {
            char[] cArr = input.ToCharArray();

            int i = 0;
            int len = input.Length;
            StringBuilder newInput = new StringBuilder(len);

            while (i < len)
            {
                if (cArr[i] == '+' || cArr[i] == '.' || (cArr[i] > 47 && cArr[i] < 58))
                    newInput.Append(cArr[i]);
                else
                    newInput.Append(',');
                i++;
            }
            return newInput.ToString();
        }

        public static bool WSCheck(string input)
        {
            bool i = true;
            foreach(char c in input)
                if (c != ' ')
                {
                    i = false;
                    break;
                }
            return i;
        }

        public static bool isNegativeKostyli(string input)
        {   
            char[] cArr = input.ToCharArray();
            bool i = false;
            int a = input.Length;
            while (--a > 0)
                if (cArr[a] > 47 && cArr[a] < 58 && cArr[a - 1] == '-')
                {
                    i = true;
                    break;
                }
            return i;
        }
    }
}