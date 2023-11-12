using System;
namespace ExerciseOrder.Entities
{
    internal class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }

        //Construtor
        public OrderItem()
        {
        }

        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        //Função mostrar total
        public double subTotal()
        {
            return Quantity * Price;
        }
    }
}
