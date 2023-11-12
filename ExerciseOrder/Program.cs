using System;
using System.Globalization;
using ExerciseOrder.Entities;
using ExerciseOrder.Entities.Enum;
using System.Collections.Generic;
namespace ExerciseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth Date (dd/mm/yyyy): ");
            DateTime dateBirth = DateTime.Parse(Console.ReadLine());
            Client client = new Client(name, email, dateBirth);

            Console.WriteLine("Enter Order Data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            DateTime moment = DateTime.Now;
            Order order = new Order(moment, status, client);
            
            Console.WriteLine("How many items to this ortem?: ");
            int qntd = int.Parse(Console.ReadLine());
            for (int i = 0; i < qntd; i++)
            {
                Console.Write($"Enter #{i+1} item data:\n");
                Console.Write("Product Name: ");
                string nameProduct = Console.ReadLine();
                Console.Write("Product Price: R$");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                int qnt = int.Parse(Console.ReadLine());
                Product product = new Product(nameProduct, price);
                OrderItem item = new OrderItem(qnt,product.Price, product);
                order.addItem(item);
                Console.WriteLine();
            }
            Console.WriteLine(order);
        }
    }
}