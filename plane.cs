using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace newProj
{
    internal class plane
    {
        public void fly()
        {
            Console.WriteLine("plane is flying ");
        }
        public void land()
        {
            Console.WriteLine("plane is landing");
        }
       
    }
    internal class passengerPlane() : plane
    {
        public void carryPassenger()
        {
            Console.WriteLine("passenger plane carry passengers");
        }
        public void fly()
        {
            Console.WriteLine("passengerplane is flying at medium Levels");
        }

    }
    internal class cargoPlane() : plane
    {
        public void carryCargo()
        {
            Console.WriteLine("cargo plane carry goods");
        }
        public void fly()
        {
            Console.WriteLine("cargoplane is flying at low Levels");
        }

    }
    internal class fighterPlane() : plane
    {
        public void carryWeapons()
        {
            Console.WriteLine("fighter plane carry weapons");
        }
        public void fly()
        {
            Console.WriteLine("fighterplane is flying at high Levels");
        }

    }
   
}
