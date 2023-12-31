﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_StringToInteger
{
    public class Program
    {
        static void Main(string[] args)
        {
            string s1 = "42";
            string s2 = "   -42";
            string s3 = "4193 with words";
            string s4 = "3.14159";
            string s5 = "      -11919730356x";



            MyAtoi(s1);
            MyAtoi(s2);
            MyAtoi(s3);
            MyAtoi(s4);
            MyAtoi(s5);
        }

        public static int MyAtoi(string s)
        {
            if (s.Length > 200 || String.IsNullOrEmpty(s)) return 0;
            int res;

            StringBuilder sb = new StringBuilder(s);

            while (sb[0] == ' ')
            {
                sb.Remove(0, 1);
                if (String.IsNullOrEmpty(sb.ToString())) return 0;
            }

            if (!Char.IsDigit(sb[0]))
            {
                if (sb[0] != '-' && sb[0] != '+')
                {
                    return 0;
                }

                if (sb.Length < 2)
                {
                    return 0;
                }

                if (!Char.IsDigit(sb[1]))
                {
                    return 0;
                }

                if (sb[0] == '+')
                {
                    sb.Remove(0, 1);

                }
            }

            for (int i = 1; i < sb.Length; i++)
            {
                if (!Char.IsDigit(sb[i]))
                {
                    sb.Remove(i, (sb.Length - i));

                }
            }

            try
            {
                res = Convert.ToInt32(sb.ToString());
            }
            catch
            {
                if (sb[0] == '-')
                {
                    res = -2147483648;

                }
                else
                {
                    res = 2147483647;
                }

            }

            return res;

        }
    }
}
