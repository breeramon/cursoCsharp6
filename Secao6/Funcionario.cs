using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Secao6
{
    class Funcionario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; private set; }

        public Funcionario(int id, string name, double salary)
        {
            this.Id = id;
            this.Name = name;
            this.Salary = salary;
        }

        public void ExibirInfo()
        {
            Console.WriteLine("ID: {0}", Id);
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("Salary: {0}", Salary);
        }
        
        public void IncreaseSalary(double percentage)
        {
            double SalarioAumentado = this.Salary + (this.Salary * percentage / 100);
            Console.WriteLine("Update Data: {0}, R$ {1}", this.Name, SalarioAumentado);
        }

        public override string ToString()
        {
            return Id + ", " + Name + ", " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
