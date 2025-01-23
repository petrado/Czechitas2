using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewCzechitas
{
    internal class Knight
    {
        public string Name { get; set; }
        public int LifeCount { get; set; }

        public DateTime dateBirth;

        public Knight(string name, int lifeCount) 
        {
            Name = name;
            LifeCount = lifeCount;
        }

        public void WriteOut()
        {
            Console.WriteLine($"My name is {Name} and I have {LifeCount} lifes.");
        }
    }
}
