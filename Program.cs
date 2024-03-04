namespace newProj
{
    internal class Program
    {

        static void Main(string[] args)
        {

            plane pl = new plane();
            passengerPlane pas = new passengerPlane();
            cargoPlane cargo = new cargoPlane();
            fighterPlane figh = new fighterPlane();

            /*plane p = pas;
            pas.land();
            pas.fly();
            pas.carryPassenger();
            p = cargo;
            cargo.land();
            cargo.fly();
            cargo.carryCargo();
            p=figh;
            figh.land();
            figh.fly();
            figh.carryWeapons();*/


            /*pas.fly();
           pas.land();
           pas.carryPassenger();
           cargo.fly();
           cargo.land();
           cargo.carryCargo();
           figh.fly();
           figh.land();
           figh.carryWeapons();*/

            Permit(pl);
            Permit(pas);
            Permit(cargo);
            Permit(figh);

            Console.ReadLine();




        }
        static void Permit(plane p)
        {
            p.fly();
            p.land();



            if (p is passengerPlane)
            {
                ((passengerPlane)p).carryPassenger();
            }

            // Check if the object is a cargoPlane, and if so, call carryCargo
            if (p is cargoPlane)
            {
                ((cargoPlane)p).carryCargo();
            }

            // Check if the object is a fighterPlane, and if so, call carryWeapons
            if (p is fighterPlane)
            {
                ((fighterPlane)p).carryWeapons();
            }
        }
    }
}