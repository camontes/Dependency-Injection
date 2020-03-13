using System;

namespace Dependency_Injection
{
    class Program
    {
        static void Main(string[] args)
        {
            Soldier soldier1 = new Soldier(new Gun());
            Soldier soldier2 = new Soldier(new Rifle());
            Soldier soldier3 = new Soldier(new Shotgun());

            Console.WriteLine(soldier1.Shoot());
            Console.WriteLine(soldier2.Shoot());
            Console.WriteLine(soldier3.Shoot());
        }
    }
}
