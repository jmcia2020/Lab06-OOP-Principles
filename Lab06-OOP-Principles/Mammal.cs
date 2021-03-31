using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_OOP_Principles
{
    public abstract class Mammal : Animal, IAquatic, IHasFur

    {
        public string HairLength()
        {
           throw new NotImplementedException();
        }

        public bool HasFur()
        {
            Console.WriteLine("Mammals have fur.");
            return true;
            //throw new NotImplementedException();
        }

        public bool Swims()
        {
            Console.WriteLine("Mammals swim.");
            return true;
            //throw new NotImplementedException();
        }
    }
}
