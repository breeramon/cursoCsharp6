using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Secao6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Preço do produto: ");
            double preco = double.Parse(Console.ReadLine());
            double desconto = (preco < 20) ? preco * 0.1 : preco * 0.05;

            Console.WriteLine(preco);
            Console.WriteLine("desconto = {0}, preço com o desconto aplicado no produto {1}", desconto, preco - desconto);

            //Console.ReadKey();
        }
    }
}
