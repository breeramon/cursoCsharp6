using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Secao6.Entities;
using Secao6.Entities.Enums;

namespace Secao6
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            Console.WriteLine(order);

            string txt = OrderStatus.PendingPayment.ToString();

            //OrderStatus os1 = Enum.Parse<OrderStatus>("Delivered");

            OrderStatus os = (OrderStatus)Enum.Parse(typeof(OrderStatus), "Delivered");

            OrderStatus os2;
            Enum.TryParse("Delivered", out os2);

            Console.WriteLine(os2);
            Console.WriteLine(os);
            Console.WriteLine(txt);
        }
    }
}
