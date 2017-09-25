using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Dog : Animal
    {
        private int eyes;
        private int legs;
        private int tail;
        private int teeth;
        private String coat;

        public Dog(String name, int size, int weight, int eyes, int legs, int tail, int teeth, String coat)
            : base (name, true, true, size, weight)
        {
            this.eyes = eyes;
            this.legs = legs;
            this.tail = tail;
            this.teeth = teeth;
            this.coat = coat;
        }

        private void Chew()
        {
            Console.WriteLine("Dog.Chew() called for the {0}", base.Name);
        }

        public override void Eat()
        {
            Console.WriteLine("Dog.Eat() called for the {0}", base.Name);
            Chew();
            base.Eat();
        }

        public void Walk()
        {
            Console.WriteLine("Dog.Walk() called for the {0}", base.Name);
            base.Move(5);
        }

        public void Run()
        {
            Console.WriteLine("Dog.Run() called for the {0}", base.Name);
            Move(10);
        }

        private void MoveLegs(int speed)
        {
            Console.WriteLine("Dog.MoveLegs() called for the {0}", base.Name);
        }

        public override void Move(int speed)
        {
            Console.WriteLine("Dog.Move() called for the {0}", base.Name);
            MoveLegs(speed);
            base.Move(speed);
        }
    }
}
