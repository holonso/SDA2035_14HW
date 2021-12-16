using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDA2035_14HW
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            Dog dog = new Dog();

            cat.ShowInfo();

            Console.WriteLine();

            dog.ShowInfo();

            Console.ReadKey();
        }

        abstract class Animal
        {
            public abstract string Name { get; set; }
            public Animal()
            {
                Name = "Никак";
            }
            public abstract void Say();
            public void ShowInfo()
            {
                Console.WriteLine("Меня зовут - {0}", Name);
                Say();
            }
        }
        class Cat : Animal
        {
            string name;

            public override string Name
            {
                get { return name; }
                set { name = "Кошка"; }
            }
            public override void Say() { Console.WriteLine("Мяу"); }
        }
        class Dog : Animal
        {
            string name;
            public override string Name
            {
                get { return name; }
                set { name = "Собака"; }
            }
            public override void Say() { Console.WriteLine("Гав"); }
        }
    }
}
