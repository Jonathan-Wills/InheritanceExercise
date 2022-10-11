using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Reptile : Animal
    {
        public bool IsColdBlooded { get; set; }
        public bool HasScales { get; set; }
        public string Environment { get; set; }
        public string Defense { get; set; }

        public Reptile()
        {

        }

        public Reptile(bool isColdBlooded, bool hasScales, string environment, string defense, int age, int legs, bool hasBackbone, string name)
        {
            IsColdBlooded = isColdBlooded;
            HasScales = hasScales;
            Environment = environment;
            Defense = defense;
            Age = age;
            Legs = legs;
            HasBackbone = hasBackbone;
            Name = name;
        }
    }
}
