using System;
using System.Collections.Generic;
using System.Linq;

namespace linq {
    class Program {
        static void Main (string[] args) {

            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string> () { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            Console.WriteLine("///// Fruits that start with L /////");
            var LFruits = fruits.Where (fruit => fruit.Contains ("L"));
            List<string> AllLFruits = new List<string> ();
            foreach (var fruit in LFruits) {
                AllLFruits.Add (fruit);
                Console.WriteLine (fruit);
            }

            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int> () {
                15,
                8,
                21,
                24,
                32,
                13,
                30,
                12,
                7,
                54,
                48,
                4,
                49,
                96
            };

            Console.WriteLine ("///// Multiples of Four OR Six /////");
            List<int> fourSixMultiples = numbers.Where (num => num % 4 == 0 || num % 6 == 0).ToList ();
            foreach (int num in fourSixMultiples) {
                Console.WriteLine (num);
            }

            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string> () {
                "Heather",
                "James",
                "Xavier",
                "Michelle",
                "Brian",
                "Nina",
                "Kathleen",
                "Sophia",
                "Amir",
                "Douglas",
                "Zarley",
                "Beatrice",
                "Theodora",
                "William",
                "Svetlana",
                "Charisse",
                "Yolanda",
                "Gregorio",
                "Jean-Paul",
                "Evangelina",
                "Viktor",
                "Jacqueline",
                "Francisco",
                "Tre"
            };

            List<string> descend = ...

        }
    }
}