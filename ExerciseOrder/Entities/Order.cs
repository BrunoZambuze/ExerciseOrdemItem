using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
using ExerciseOrder.Entities.Enum;
namespace ExerciseOrder.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> listOrdemItem { get; set; } = new List<OrderItem>();

        //Construtor
        public Order()
        {
        }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        //Função para adicionar itens
        public void addItem(OrderItem item)
        {
            listOrdemItem.Add(item);
        }

        //Função para remover itens
        public void removeItem(OrderItem item)
        {
            listOrdemItem.Remove(item);
        }

        //Função somar os valores
        public double Total()
        {
            double priceTotal = 0.0;
            foreach (OrderItem p in listOrdemItem)
            {
                priceTotal += p.subTotal();

            }
            return priceTotal;
        }

        //Impressão dos dados
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\nORDER SUMMARY:");
            sb.AppendLine($"Order Moment:{Moment.ToString("dd/MM/yyyy HH:mm")}");
            sb.AppendLine($"Order Status:{Status}");
            sb.Append($"Client:{Client.Name} ({Client.BirthDate.ToString("dd/MM/yyyy")}) - {Client.Email}");
            sb.AppendLine("\nOrder items");
            foreach (OrderItem item in listOrdemItem)
            {
                sb.Append($"{item.Product.Name}, R${item.Product.Price.ToString("F2", CultureInfo.InvariantCulture)}, Quantity:{item.Quantity}, SubTotal: R${item.subTotal().ToString("F2", CultureInfo.InvariantCulture)}");
                sb.AppendLine();
            }
            sb.AppendLine($"\n\nTotal Price: R${Total().ToString("F2", CultureInfo.InvariantCulture)}");

            return sb.ToString();
        }
    }
}
