using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1108_DefangingAnIPAdress
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DefangIPaddr("1.1.1.1"));
            Console.WriteLine(DefangIPaddr("255.100.50.0"));

            Console.ReadKey();
        }
        public static string DefangIPaddr(string address)
        {
            return address.Replace(".", "[.]");
        }


    }
}
