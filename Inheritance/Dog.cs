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
            Console.WriteLine("Dog.Chew() called");
        }

        public override void Eat()
        {
            Console.WriteLine("Dog.Eat() called");
            Chew();
            base.Eat();
        }

        public void Walk()
        {
            Console.WriteLine("Dog.Walk() called");
            base.Move(5);
        }

        public void Run()
        {
            Console.WriteLine("Dog.Run() called");
            Move(10);
        }

        private void MoveLegs(int speed)
        {
            Console.WriteLine("Dog.MoveLegs() called");
        }

        public override void Move(int speed)
        {
            Console.WriteLine("Dog.Move() called");
            MoveLegs(speed);
            base.Move(speed);
        }
    }
}
