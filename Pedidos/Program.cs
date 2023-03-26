using System.Globalization;
using System;
using Pedidos.Entities.Enums;
using Pedidos.Entities;
namespace Pedidos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Client Set//

            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name=Console.ReadLine();
            Console.Write("Email: ");
            string email=Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime birthDate=DateTime.Parse(Console.ReadLine());
            Client c1= new Client(name,email,birthDate);


            //Order//

            Console.WriteLine("Enter Order Data:");
            Console.Write("Status: ");
            OrderStatus status=Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
            Order order=new Order(DateTime.Now,status,c1);


            //Order Get//

            for(int i=1; i<=n; i++)
            {
                Console.WriteLine("Enter #"+i+" item data:");
                Console.Write("Product Name: ");
                string product= Console.ReadLine();
                Console.Write("Product Price: ");
                double price=double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int quantity=int.Parse(Console.ReadLine());
                Product products=new Product(product,price);
                OrderItem item=new OrderItem(quantity,price,products);
                order.AddItem(item);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY:");
            Console.WriteLine(order.ToString());

        }
    }
}
