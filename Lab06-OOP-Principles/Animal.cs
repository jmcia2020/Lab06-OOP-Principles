using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_OOP_Principles
{
    public abstract class Animal
    {
        public int age { get; set; }

        public abstract string Eat();

        public abstract bool Nocturnal { get; }

        public abstract string Sound();

        public abstract string Reproduce();

    }
}
