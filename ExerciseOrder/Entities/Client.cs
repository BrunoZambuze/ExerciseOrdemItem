using System;

namespace ExerciseOrder.Entities
{
    internal class Client
    {
        public string Name { get; private set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }

        //Construtor
        public Client()
        {
        }

        public Client(string name, string email, DateTime birth)
        {
            Name = name;
            Email = email;
            BirthDate = birth;
        }
    }
}
