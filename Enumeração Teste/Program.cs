using Enumeração_Teste.Entities;
using Enumeração_Teste.Entities.Enums;
using System;

namespace Enumeração_Teste
{
    class Program
    {
        static void Main(string[] args)
        {
            Order d1 = new Order {Id=0001,Moment=DateTime.Now,Status=OrderStatus.PedingPayment};
            Console.WriteLine(d1);
            Console.WriteLine();
            Console.WriteLine("Conversão de string para enumeração");
            string status = OrderStatus.PedingPayment.ToString();// conversão de string para enumeração
            Console.WriteLine(status);
            Console.WriteLine();
            Console.WriteLine("Conversão de enumeração para string");
            OrderStatus os = Enum.Parse<OrderStatus>("Delivered");//conversão de numeração para string
            Console.WriteLine(os);
        }
    }
}
