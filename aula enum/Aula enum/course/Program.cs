using System;
using course.Entities;
using course.Entities.Enums;

namespace course
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order{
            Id = 1,
            Moment = DateTime.Now,
            Status = OrderStatus.Processing
            };

            Console.WriteLine(order.ToString());
            //conversão de enum para string, usando o ToString
            string vTxt = OrderStatus.Delivered.ToString();
            Console.WriteLine(vTxt);
            //Conversão de texto para Enum, utiliza-se o Enum.Parsse<TipoDoEnum>(string):
            OrderStatus os = Enum.Parse<OrderStatus>("Processing");

            Console.WriteLine(os);

        }
    }
}
