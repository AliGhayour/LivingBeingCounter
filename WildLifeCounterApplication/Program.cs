using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp1.CompositeSanctury;

namespace WildLifeCounterApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var nationalParks = new SingleSanctury("NationalParks", 256);
            nationalParks.CalculateTotalCount();
            Console.WriteLine();

            //composite sanctury
            var rootSanctury = new CompositeSanctury("RootSanctury", 0);
            var wildRabbit = new SingleSanctury("WildRabbit", 289);
            var fox = new SingleSanctury("Fox", 587);
            rootSanctury.Add(wildRabbit);
            rootSanctury.Add(fox);

            var wildLife = new CompositeSanctury("WildLife", 0);
            var birds = new SingleSanctury("Birds", 200);
            var plantspecies = new SingleSanctury("Plantspecies", 150);

            wildLife.Add(birds);
            wildLife.Add(plantspecies);
            rootSanctury.Add(wildLife);



            Console.WriteLine();
            Console.WriteLine($" Total count of this composite present is: {rootSanctury.CalculateTotalCount()}");

        }
    }
}
