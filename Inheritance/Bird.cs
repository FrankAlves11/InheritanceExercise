using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Bird : Animal
    {
        public bool Wings { get; set; }
        public string Type { get; set; }
        public bool CrossedTheRoad { get; set; }
        public string HasFeathers { get; set; }
    
        public Bird()
        {

        }

        public Bird(int age, int legs, bool hasBackBone, string name, bool wings, string type, bool crossedTheRoad, string hasFeathers)
        {
            Age = age;
            Legs = legs;
            HasBackBone = hasBackBone;
            Name = name;
            Wings = wings;
            Type = type;
            CrossedTheRoad = crossedTheRoad;
            HasFeathers = hasFeathers;


        }



    }
}
