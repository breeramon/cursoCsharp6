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
            TimeSpan t1 = TimeSpan.FromDays(2); // pode ser em um dia quebrado como 1 dia e meio = 1.5
            TimeSpan t2 = TimeSpan.FromHours(24); // tbm pode ser quebrado como 2 horas e meia = 2.5
            TimeSpan t3 = TimeSpan.FromMinutes(1.5);
            TimeSpan t4 = TimeSpan.FromSeconds(1.5);
            TimeSpan t5 = TimeSpan.FromMilliseconds(1.5);
            TimeSpan t6 = TimeSpan.FromTicks(900000000L);
            

            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine(t4);
            Console.WriteLine(t5);
            Console.WriteLine(t6);

            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);

            DateTime d1 = new DateTime(2020, 12, 21);

            DateTime d2 = new DateTime(2020, 12, 23);

            DateTime y = d1.Add(t1); 
            DateTime y1 = d1.AddDays(2);
            DateTime y2 = d1.AddHours(2);
            DateTime y3 = d1.AddMilliseconds(2);
            DateTime y4 = d1.AddMinutes(2);
            DateTime y5 = d1.AddMonths(2);
            DateTime y6 = d1.AddSeconds(2);
            DateTime y7 = d1.AddTicks(900000000L);
            DateTime y8 = d1.AddYears(2);
            DateTime y9 = d1.Subtract(t2);
            TimeSpan t = d1.Subtract(d2);
        }
    }
}
