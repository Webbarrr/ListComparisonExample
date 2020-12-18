using System;
using System.Collections.Generic;

namespace ListComparisonExample
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // make the lists
            var a = GetListA();
            var b = GetListB();

            var c = new List<Model>(); // should contain the matching element (ID 1 only)

            foreach (var item in b)
            {
                if (a.Contains(item))
                {
                    c.Add(item);
                }
            }

            foreach (var item in c)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Value);
            }

            Console.WriteLine();
            Console.WriteLine("Finished");
            Console.ReadLine();
        }

        static private List<Model> GetListA()
        {
            var models = new List<Model>();

            models.Add(new Model
            {
                Id = 1,
                Name = "Webbarr",
                Value = "Hello, World!"
            }); // will exist in both lists

            models.Add(new Model
            {
                Id = 2,
                Name = "Dave",
                Value = "Alright, Dave"
            }); // won't exist in both

            models.Add(new Model
            {
                Id = 3,
                Name = "Jeff",
                Value = "An extra item"
            });

            return models;
        }

        static private List<Model> GetListB()
        {
            var models = new List<Model>();

            models.Add(new Model
            {
                Id = 1,
                Name = "Webbarr",
                Value = "Hello, World!"
            }); // will exist in both lists

            models.Add(new Model
            {
                Id = 2,
                Name = "Dave",
                Value = "Alright Dave"
            }); // won't exist in both

            return models;
        }
    }

    public class Model : IEquatable<Model>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Value { get; set; }

        public bool Equals(Model other)
        {
            if (this.Id != other.Id) return false;
            if (this.Name != other.Name) return false;
            if (this.Value != other.Value) return false;

            return true;
        }
    }
}