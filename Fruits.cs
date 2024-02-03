using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListboxGyumi
{
    internal class Fruits
    {
        ulong productC;
        string name;
        int amount;

        public ulong ProductC { get => productC; set => productC = value; }
        public string Name { get => name; set => name = value; }
        public int Amount { get => amount; set => amount = value; }

        public Fruits(ulong productC, string name, int amount)
        {
            ProductC = productC;
            Name = name;
            Amount = amount;
        }

        public int AmountB()
        {
            return this.amount;
        }

        public override string ToString()
        {
            return $"{this.productC};{this.name} ({this.AmountB()} kg)";
        }

        public string toTxt()
        {
            return $"{this.productC};{this.name};{this.amount} kg\r\n";
        }

    }
}
