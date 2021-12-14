using System;

namespace Task14
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.ShowInfo();
            Dog dog = new Dog();
            dog.ShowInfo();

            Console.ReadKey();
        }
    }

    abstract class Animal
    {
        public abstract string Name { get; }
        protected abstract string GetName();
        public Animal(string name)
        {
        }
        public abstract void Say();
        public void ShowInfo()
        {
            Console.Write(GetName() + ":");
            Say();
        }
    }

    class Cat : Animal
    {
        public override string Name => "кошка";

        public Cat() : base("")
        {
        }

        protected override string GetName()
        {
            return Name;
        }

        public override void Say()
        {
            Console.WriteLine("мяу");
        }
    }
    class Dog : Animal
    {
        public override string Name => "собака";

        public Dog() : base("")
        {
        }
        protected override string GetName()
        {
            return Name;
        }
        public override void Say()
        {
            Console.WriteLine("гав");
        }
    }
}

