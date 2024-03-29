using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
       public abstract class Animal
    {
        public string Name { get; set; }
        public string Colour { get; set; }
        public int Age { get; set; }

        public string GetName()
        {
            return Name;
        }

        public string GetColour()
        {
            return Colour;
        }

        public int GetAge()
        {
            return Age;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public void SetColour(string colour)
        {
            Colour = colour;
        }

        public void SetAge(int age)
        {
            Age = age;
        }

        public abstract void Eat();
    }

    public class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Dogs eat meat.");
        }
    }

    public class Cat : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Cats eat mice.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter dog's name:");
            string dogName = Console.ReadLine();

            Dog dog = new Dog();
            dog.SetName(dogName);

            Console.WriteLine("Enter dog's colour:");
            dog.SetColour(Console.ReadLine());

            Console.WriteLine("Enter dog's age:");
            int dogAge;
            while (!int.TryParse(Console.ReadLine(), out dogAge))
            {
                Console.WriteLine("Invalid input. Please enter a valid age:");
            }
            dog.SetAge(dogAge);

            Console.WriteLine($"Dog Name: {dog.GetName()}, Colour: {dog.GetColour()}, Age: {dog.GetAge()}");
            dog.Eat();

            Console.WriteLine("\nEnter cat's name:");
            string catName = Console.ReadLine();

            Cat cat = new Cat();
            cat.SetName(catName);

            Console.WriteLine("Enter cat's colour:");
            cat.SetColour(Console.ReadLine());

            Console.WriteLine("Enter cat's age:");
            int catAge;
            while (!int.TryParse(Console.ReadLine(), out catAge))
            {
                Console.WriteLine("Invalid input. Please enter a valid age:");
            }
            cat.SetAge(catAge);

            Console.WriteLine($"Cat Name: {cat.GetName()}, Colour: {cat.GetColour()}, Age: {cat.GetAge()}");
            cat.Eat();
            Console.ReadLine();
        }
    }



}