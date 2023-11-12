using System;

namespace ExerciseOrder.Entities
{
    internal class Product
    {
        public string Name { get; private set; }
        public double Price { get; set; }

        //Construtor
        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }
}
