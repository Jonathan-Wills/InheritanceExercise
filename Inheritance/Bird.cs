using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Bird : Animal
    {
        public int Wings { get; set; }
        public string Type { get; set; }
        public bool IsWarmBlooded { get; set; }
        public bool HasFeathers { get; set; }

        public Bird()
        {

        }

        public Bird(int wings, string type, bool isWarmBlooded, bool hasFeathers, int age, int legs, bool hasBackbone, string name)
        {
            Wings = wings;
            Type = type;
            IsWarmBlooded = isWarmBlooded;
            HasFeathers = hasFeathers;
            Age = age;
            Legs = legs;
            HasBackbone = hasBackbone;
            Name = name;
        }

    }
}
