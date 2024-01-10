using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_ReverseInteger
{
    public class Program
    {
        static void Main(string[] args)
        {
            int teste1 = 123;
            int teste2 = -123;
            int teste3 = 120;


            Console.WriteLine(Reverse(teste1));
            Console.WriteLine(Reverse(teste2));
            Console.WriteLine(Reverse(teste3));

            Console.ReadKey();
        }

        public static int Reverse(int x)
        {
            if (x == 0)
            {
                return 0;
            }

            StringBuilder intNormal = new StringBuilder(x.ToString());
            StringBuilder intReversed = new StringBuilder();
            char aux = intNormal[intNormal.Length - 1];

            

            if (intNormal[0] == '-')
            {
                intReversed = intReversed.Append('-');
                intNormal = intNormal.Remove(0, 1);
            }

            while (aux == '0')
            {
                intNormal = intNormal.Remove(intNormal.Length - 1, 1);
                aux = intNormal[intNormal.Length - 1];
            }

            while (intNormal.Length > 0)
            {
                intReversed.Append(aux);
                intNormal = intNormal.Remove(intNormal.Length - 1, 1);

                if (intNormal.Length != 0)
                {
                    aux = intNormal[intNormal.Length - 1];
                }
            }

            long reversed = Convert.ToInt64(intReversed.ToString());

            if (reversed > 2147483647 || reversed < -2147483648 || reversed == 0)
            {
                return 0;
            }

            return Convert.ToInt32(intReversed.ToString());

            
        }


    }
}
