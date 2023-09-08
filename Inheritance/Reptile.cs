using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Reptile : Animal
    {
        public bool IsColdBlooded { get; set; }
        public string Environment { get; set; }
        public bool HasScales { get; set; }
        public bool IsAFastBoy { get; set; }


        public Reptile()
        {

        }

        public Reptile(int age, int legs, bool hasBackBone, string name, bool isColdBlooded, string environment, bool hasScales, bool isAFastBoy)
        {
            Age = age;
            Legs = legs;
            HasBackBone = hasBackBone;
            Name = name;
            IsColdBlooded = isColdBlooded;
            Environment = environment;
            HasScales = hasScales;
            IsAFastBoy = isAFastBoy;
        }
    }
}
