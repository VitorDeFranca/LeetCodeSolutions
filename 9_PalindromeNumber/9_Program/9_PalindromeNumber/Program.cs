using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_PalindromeNumber
{
    public class Program
    {
        static void Main(string[] args)
        {
            
        }

        public bool IsPalindrome(int x) 
        {
            string stringNum = x.ToString();
            StringBuilder stringNumReversed = new StringBuilder();
            int aux = stringNum.Length - 1;

            while (aux >= 0)
            {
                stringNumReversed.Append(stringNum[aux]);
                aux--;
            }

            return stringNum.Equals(stringNumReversed.ToString());
        }



    }
}
