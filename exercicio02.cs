using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio02
{
    internal class Program
    {
        static double ObterHipotenusa (double a, double b)
        {
            double hipotenusa;
            hipotenusa = Math.Sqrt(((a*a) + (b*b)));
            return hipotenusa;
        }
        static void Main(string[] args)
        {
            double a, b, resultado;
            Console.WriteLine("Digite o valor do cateto a");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do cateto b");
            b = double.Parse(Console.ReadLine());
            resultado = ObterHipotenusa(a, b);
            Console.WriteLine($"Resultado da hipotenusa = {resultado}");
        }
    }
}
