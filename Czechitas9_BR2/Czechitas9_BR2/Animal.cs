using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Czechitas9_BR2
{
    public class Animal
    {
        public string Species { get; set; }
        public string Name { get; set; }
        public double LegsCount { get; set; }

        public Animal(string species, string name, double legsCount)
        {
            Species = species;
            Name = name;
            LegsCount = legsCount;
        }

        public Animal() { }
    }
}
