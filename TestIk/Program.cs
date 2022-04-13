using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using static TestIk.BinaryTee;

namespace TestIk
{
    class Program
    {
        static void Main(string[] args)
        {
            var gList = new GenericClass();
            gList.DoSomething<double>(2.5);
            gList.DoSomething<Animal>(new Animal { Name = "Animale Name" });

            //2
            var list = new LinkedList();
            for (int i = 0; i < 10; i++)
                list.AddNode(new LinkedList.LinkListNode(i));

            list.ReverseList();
            list.ReverseListRecursion();
            list.PrintList();
            Console.WriteLine();

            //3
            var ana = new AnagramOrNot();
            var result = ana.Check("abc", "cba");
            Console.WriteLine($"Equal ? {result}");

            //4
            var bTree = new BinaryTee();
            bTree.Output();
        }
    }

    public class AnagramOrNot
    {
        public bool Check(string a, string b)
        {
            if (a == null || b == null)
                return false;

            if (a.Length != b.Length)
                return false;

            return a.OrderBy(x => x).SequenceEqual(b.OrderBy(x => x));
        }
    }

    public class GenericClass
    {
        public void DoSomething<T>(T value)
        {
            if (typeof(T).Equals(typeof(Animal)))
            {
                var animal = value as Animal;
                Console.WriteLine($"Value = {animal.Name}");
            }
            else
            {
                Console.WriteLine($"Value = {value}");
            }
        }
    }
    public class Animal
    {
        public string Name { get; set; }
        public List<string> Habitats { get; set; }
    }
    public class AnimalList
    {
        public void DoSomething(Animal animal)
        {
            Console.WriteLine("Foo Animal");
        }
    }
    public class DoubleList
    {
        public void DoSomething(double number)
        {
            Console.WriteLine("Foo Number");
        }
    }
}
