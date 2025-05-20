using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace exercicio03
{
    internal class Program
    {
        static int CalcularMMC(int n1, int n2)
        {
            int mmc = 1, teste;
            for (int i = 1; n1 == 1 && n2 == 1; i++)
            {
                n1 = n1 / i;
                n2 = n2 / i;

                if (n1 % i == 0 && n2 % i == 0)
                {
                    mmc *= i;
                }
                else
                {
                    n1 = n1 * i;
                    n2 *= i;
                }
            
            }
            return mmc;
        }

      
        static void Main(string[] args)
        {
            int n1, n2, mmc;
            Console.WriteLine("Digite n1");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite n2");
            n2 = int.Parse(Console.ReadLine());

            mmc = CalcularMMC(n1, n2);
            Console.WriteLine(mmc);

        }
    }
}
