using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Animal
    {
        private String name;
        private bool brain;
        private bool body;
        private int size;
        private int weight;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        // constructor
        public Animal(String name, bool brain, bool body, int size, int weight)
        {
            this.Name = name;
            this.brain = brain;
            this.body = body;
            this.size = size;
            this.weight = weight;
        }

        public virtual void Eat()
        {
            Console.WriteLine("Animal.Eat() called");
        }

        public virtual void Move(int speed)
        {
            Console.WriteLine("Animal.Move() called. Animal is moving at " + speed);
        }
    }
}
