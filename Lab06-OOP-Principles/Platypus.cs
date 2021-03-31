using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab06_OOP_Principles
{
    public virtual class Platypus : Mammal, IHasBeak, IAquatic, ILaysEggs, IHasFur
    {
        public bool HasFur()
        {
            Console.WriteLine("Platypuses have fur.");
            return true;
            //throw new NotImplementedException();
        }
        public string HairLength()
        {
            Console.WriteLine("Platypuses have short hair.");
            //throw new NotImplementedException();;
        }

        public bool HasBeak()
        {
            Console.WriteLine("Platypuses have beaks.");
            return true;
            //throw new NotImplementedException();
        }

        public bool LaysEggs()
        {
            Console.WriteLine("Platypuses lay eggs.");
            return true;
            //throw new NotImplementedException();
        }

        public int NumEggs()
        {
            throw new NotImplementedException();
        }

        public bool Swims()
        {
            Console.WriteLine("Platypuses swim.");
            return true;
            //throw new NotImplementedException();
        }
    }
}
  