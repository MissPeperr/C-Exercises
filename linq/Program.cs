using System;
using System.Collections.Generic;
using System.Linq;

namespace linq {
    class Program {
        static void Main (string[] args) {

            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string> () { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            Console.WriteLine ("///// Fruits that start with L /////");
            var LFruits = fruits.Where(fruit => fruit.Contains ("L")).ToList();
            foreach (var fruit in LFruits) {
                Console.WriteLine (fruit);
            }

            // Which of the following numbers are multiples of 4 or 6
            List<int> firstNumbers = new List<int> () {
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
            List<int> fourSixMultiples = firstNumbers.Where (num => num % 4 == 0 || num % 6 == 0).ToList ();
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

            Console.WriteLine ("///// Students in Descending Alphebetical Order /////");
            List<string> descend = (
                from name in names 
                orderby name descending 
                select name).ToList ();
            descend.ForEach (name => Console.WriteLine ($@"{name}"));

            Console.WriteLine ("///// How many Numbers? Aggregate Operations /////");
            // Output how many numbers are in this list
            List<int> secondNumbers = new List<int> () {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };
            Console.WriteLine ($"{secondNumbers.Count()} total numbers");

            // How much money have we made?
            List<double> purchases = new List<double> () {
                2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            };
            Console.WriteLine ($"Total $$ made: {purchases.Sum()}");

            // What is our most expensive product?
            List<double> prices = new List<double> () {
                879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            };
            Console.WriteLine ($"Most Expensive Product: {prices.Max()}");

            /*
                Store each number in the following List until a perfect square
                is detected.

                Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
            */
            Console.WriteLine("///// Square Root /////");
            List<int> wheresSquaredo = new List<int> () {
                66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
            };
            wheresSquaredo.ForEach(num => 
            {
                if(Math.Sqrt(num) % 1 == 0)
                {
                    Console.WriteLine(Math.Sqrt(num));
                }
            });

            /*
                Given the same customer set, display how many millionaires per bank.
                Ref: https://stackoverflow.com/questions/7325278/group-by-in-linq

                Example Output:
                    WF 2
                    BOA 1
                    FTB 1
                    CITI 1
            */
            Console.WriteLine("///// How many millionaires per bank? /////");
            List<Customer> customers = new List<Customer>() {
                new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
                new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
                new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
                new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
                new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
                new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
                new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
                new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
                new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
                new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
            };

            /*
                where the customer.Balance is greater than 999999.99
                group the customer by the customer.Bank into a new list called 'g'
                select or return a new object with the key of Bank and a value of Person
                    Bank contains the Key of 'g', 
                    Person contains the entire 'g' and puts it into a List
            
            */
            var bankGroup = from customer in customers
                where customer.Balance > 999999.99
                group customer by customer.Bank into g
                select new {Bank = g.Key, Person = g.ToList()};
            /*
                for each customer in 'bankGroup',
                WriteLine customer.Bank (key) and the length of customer.Person.Count (value)
            */
            foreach(var customer in bankGroup)
            {
                Console.WriteLine($"{customer.Bank}: {customer.Person.Count()}");
            }

            /*
                TASK:
                    As in the previous exercise, you're going to output the millionaires,
                    but you will also display the full name of the bank. You also need
                    to sort the millionaires' names, ascending by their LAST name.

                Example output:
                    Tina Fey at Citibank
                    Joe Landy at Wells Fargo
                    Sarah Ng at First Tennessee
                    Les Paul at Wells Fargo
                    Peg Vale at Bank of America
            */


            // Create some banks and store in a List
            List<Bank> banks = new List<Bank>() {
                new Bank(){ Name="First Tennessee", Symbol="FTB"},
                new Bank(){ Name="Wells Fargo", Symbol="WF"},
                new Bank(){ Name="Bank of America", Symbol="BOA"},
                new Bank(){ Name="Citibank", Symbol="CITI"},
            };

            var millionaireReport = (from customer in customers
                join bank in banks on customer.Bank equals bank.Symbol into bc
                from bank in bc
                select new {BankName = bank.Name, CustomerName = customer.Name}).ToList();
            
            

            foreach (var reportInfo in millionaireReport)
            {
                Console.WriteLine($"{reportInfo.CustomerName} at {reportInfo.BankName}");
            }
        }
    }
}