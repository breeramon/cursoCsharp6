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
            Console.Write("Digite o número de Funcionários para cadastrar: ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>();

            for (int i = 1; i <= n; i++)
            {
                Console.Write("Digite o Id do funcionario: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Digite o nome do funcionario: ");
                string name = Console.ReadLine();

                Console.Write("Digite o salário do funcionário: ");
                double salary = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

                list.Add(new Funcionario(id, name, salary));
                Console.WriteLine("");
            }

            Console.Write("Digite o Id do funcionário que vai receber o aumento: ");
            int searchId = int.Parse(Console.ReadLine());

            Funcionario emp = list.Find(x => x.Id == searchId);
            if (emp != null)
            {
                Console.Write("Valor da porcentagem: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("Esse Id não existe!");
            }

            Console.WriteLine();
            Console.WriteLine("Updated list of Funcionarios:");

            foreach (Funcionario obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.ReadKey();
        }
    }
}
