using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_OOP_Principles
{
    class Penguin: Bird, IAquatic
    {
        public override bool Flies { get { return false; } }

        public bool HasBeak()
        {
            Console.WriteLine("Penguins have beaks.");
            return true;
            //throw new NotImplementedException();
        }

        public bool LaysEggs()
        {
            Console.WriteLine("Penguins lay eggs.");
            return true;
            //throw new NotImplementedException();
        }

        public int NumEggs()
        {
            throw new NotImplementedException();
        }

        public bool Swims()
        {
            Console.WriteLine("Penguins swing.");
            return true;
            //throw new NotImplementedException();
        }
    }
}
