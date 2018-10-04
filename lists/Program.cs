using System;
using System.Collections.Generic;

namespace lists {
    class Program {
        static void Main (string[] args) {
            // created a new list called "planetList", contains two planets
            List<string> planetList = new List<string> () { "Mercury", "Mars" };

            // add two new planets into the "planetList" List
            planetList.Add ("Jupiter");
            planetList.Add ("Saturn");

            // created a new list called "lastPlanets", contains two planets
            List<string> lastPlanets = new List<string> () { "Neptune", "Uranus" };

            // added the entire list of "lastPlanets" to the list "planetList"
            planetList.AddRange(lastPlanets);

            /* Inserted two planets at two different indexes, added "Pluto" at the very end of the List, then removed it because Pluto isn't actually a planet :(
            */
            planetList.Insert (1, "Venus");
            planetList.Insert (2, "Earth");
            planetList.Add ("Pluto");
            planetList.Remove ("Pluto");

            // Created a new list called "rockyPlanets" that has the planets that are made out of rock from "planetList"
            List<string> rockyPlanets = planetList.GetRange (0, 4);
            // testing if planets were added to "rockyPlanets"
            rockyPlanets.ForEach (planet => Console.WriteLine ($"Rocky Planets: {planet}"));

            // Created a new list, that contains dictionaries called "allProbes"
            List<Dictionary<string, string>> allProbes = new List<Dictionary<string, string>> () {
                new Dictionary<string, string> () {{ "Venus", "Venus 1" }},
                new Dictionary<string, string> () {{ "Mars", "Mariner 3" }},
                new Dictionary<string, string> () {{ "Jupiter", "Juno" }},
                new Dictionary<string, string> () {{ "Saturn", "Pioneer 11" }}
            };

            // loop over the "planetList" List
            foreach (string planet in planetList) // iterate planets
            {
                // created an empty list called "matchingProbes"
                List<string> matchingProbes = new List<string> ();

                // loop over the "allProbes" List
                foreach (Dictionary<string, string> probe in allProbes) // iterate probes
                {
                    /*
                        Does the current Dictionary contain the key of
                        the current planet? Investigate the ContainsKey(planet)
                        method on a Dictionary.

                        If so, add the current spacecraft to `matchingProbes`.
                    */
                        if(probe.ContainsKey(planet)){

                            matchingProbes.Add(probe[planet]);
                        }
                }

                /*
                    Use String.Join(",", matchingProbes) as part of the
                    solution to get the output below. It's the C# way of
                    writing `array.join(",")` in JavaScript.
                */
                // string completedList = string.Join(", ", matchingProbes);
                Console.WriteLine($"{planet}: {String.Join(", ", matchingProbes)}");
            }
        }
    }
}