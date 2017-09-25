using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal("Animal", true, true, 5, 5);
            Dog dog = new Dog("Yorkie", 8, 20, 2, 4, 1, 20, "long silky");

            animal.Eat();
            dog.Eat();
            dog.Walk();
            dog.Run();

            Console.Read();
        }
    }
}
