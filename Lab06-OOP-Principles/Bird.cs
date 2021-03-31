using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_OOP_Principles
{
    public abstract class Bird: Animal, ILaysEggs, IHasBeak
    {
        public abstract bool Flies { get; }

        public bool HasBeak()
        {
            Console.WriteLine("Birds have beaks.");
            return true;
            //throw new NotImplementedException();
        }

        public bool LaysEggs()
        {
            Console.WriteLine("Birds Lay eggs..");
            return true;
            //throw new NotImplementedException();
        }

        public int NumEggs()
        {
            throw new NotImplementedException();
        }
    }
}
