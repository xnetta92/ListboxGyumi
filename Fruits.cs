using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListboxGyumi
{
    internal class Fruits
    {
        string productC;
        string name;
        int amount;

        public string ProductC { get => productC; set => productC = value; }
        public string Name { get => name; set => name = value; }
        public int Amount { get => amount; set => amount = value; }

        public Fruits(string productC, string name, int amount)
        {
            ProductC = productC;
            Name = name;
            Amount = amount;
        }

    }
}
