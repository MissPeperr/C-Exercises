using System;
using System.Collections.Generic;

namespace sets
{
    class Program
    {
        static void Main(string[] args)
        {
            // created an empty HashSet called "Showroom"
            HashSet<string> Showroom = new HashSet<string>();

            // added 4 cars to "Showroom"
            Showroom.Add("Model 3");
            Showroom.Add("4Runner");
            Showroom.Add("Fusion");
            Showroom.Add("Wrangler");
            /* 
             added "Model 3" again to show that HashSets have UNIQUE items 
             so Model 3 will only appear once in the console
            */
            Showroom.Add("Model 3");


            // created an empty HashSet called "UsedLot"
            HashSet<string> UsedLot = new HashSet<string>();

            // added two cars to "UsedLot"
            UsedLot.Add("Fiesta");
            UsedLot.Add("F350");
            
            // added the HashSet "UsedLot" to the HashSet "Showroom"
            Showroom.UnionWith(UsedLot);

            // removing 1 car from the "Showroom" HashSet
            Showroom.Remove("Fusion");

            // printing to console to make sure cars were added
            Console.WriteLine("///// Showroom Console /////");
            foreach(string vehicle in Showroom)
            {
                Console.WriteLine(vehicle);
            }

            // created an empty HashSet called "Junkyard"
            HashSet<string> Junkyard = new HashSet<string>();

            // added 4 cars to the HashSet "Junkyard"
            Junkyard.Add("Camry");
            Junkyard.Add("Sonata");
            Junkyard.Add("Prius");
            Junkyard.Add("Taurus");
            // added 2 cars that are named the same from "Showroom" to "Junkyard"
            Junkyard.Add("Model 3");
            Junkyard.Add("4Runner");

            // created a new "Showroom" HashSet
            HashSet<string> clone = new HashSet<string>(Showroom);
            
            // checking to see if any vehicles in the clone of "Showroom" match in "Junkyard"
            clone.IntersectWith(Junkyard);

            // looping over the clone HashSet to see the matching vehicles
            Console.WriteLine("///// Clone Console /////");
            foreach(string vehicle in clone)
            {
                Console.WriteLine(vehicle);
            }

            // added HashSet "Junkyard" to HashSet "Showroom"
            Showroom.UnionWith(Junkyard);

            // printing to console to make sure cars were added
            Console.WriteLine("///// Added Junkyard to Showroom Console ///// ");
            foreach(string vehicle in Showroom)
            {
                Console.WriteLine(vehicle);
            }

        }
    }
}
