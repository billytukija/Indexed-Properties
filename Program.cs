using System;
using System.Collections.Generic;

namespace IndexedProprieties
{
    public class Product {
        
        List<string> names;

        public Product()
        {
            names = new List<string>();
        }

        public void Add(string name)
        {
            names.Add(name);
        }

        //public string Get(int idx)
        //{
        //    return names[idx];
        //}

        // Indexed proprierties

        public string this [int index]
        {
            get {
                return this.names[index];   
            }
        }

        public int this [string name]
        {
            get
            {
                return this.names.IndexOf(name);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var prods = new Product();
            prods.Add("Billy");

            Console.WriteLine(prods[0]);
            Console.WriteLine("Billy's position is : " + prods["Billy"]);
        }
    }
}
