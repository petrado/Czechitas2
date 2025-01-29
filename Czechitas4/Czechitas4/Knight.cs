using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Czechitas4
{
    internal class Knight
    {
        public string Name;
        public int LifeCount;

        public Knight(string name, int lifeCount)
        {
            Name = name;
            LifeCount = lifeCount;
        }

        public void WriteNameAndLifes()
        {
            Console.WriteLine($"My name is {Name} and i have {LifeCount} lives. ");
        }
    }
}
