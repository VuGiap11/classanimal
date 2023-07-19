using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace classanimal
{
    internal abstract class Animal
    {
        private string height;
        private string weight;

        public string Height { get => height; set => height = value; }
        public string Weight { get => weight; set => weight = value; }


        public Animal(string height, string weight)
        {
            this.Height = height;
            this.Weight = weight;
        }

        public abstract void Showinfo();
    }

    class Cat : Animal
    {
        private string name;
        public string Name { get => name; set => name = value; }

        public Cat(string height, string weight, string name) : base(height, weight)
        {
            this.Name = name;
        }
        public override void Showinfo()
        {
            Console.WriteLine("height: {0} " + '\n' + "weight : {1}" + '\n' + "name: {2}", this.Height, this.Weight, this.Name);
        }
    }
}
