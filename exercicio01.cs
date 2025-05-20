using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio01
{
    internal class Program
    {
        static int ObterMenor(int n1, int n2, int n3, int n4)
        {
            int menor;
            if (n1 <= n2 && n1 <= n3 && n1 <= n4)
            {
                menor = n1;
            }

            else if (n2 <= n1 && n2 <= n3 && n2 <= n4)
            {
                menor = n2;
            }
            else if (n3 <= n1 && n3 <= n2 && n3 <= n4)
            {
                menor = n3;
            } 
            else
            {
                menor = n4;
            }
            return menor;
        }
        static void Main(string[] args)
        {
            int n1, n2, n3, n4;
            Console.WriteLine("Digite os valores:");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            n4 = int.Parse(Console.ReadLine());

            int menor = ObterMenor(n1,n2,n3,n4);
            Console.WriteLine($"Menor valor: {menor}");

        }
    }
}
