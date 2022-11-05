﻿
// Define a bank
public class Bank
{
    public string Symbol { get; set; }
    public string Name { get; set; }
}

// Define a customer
public class Customer
{
    public string Name { get; set; }
    public double Balance { get; set; }
    public string Bank { get; set; }
}

public class GroupedMillionaires
{
    public string Bank { get; set; }
    public IEnumerable<string> Millionaires { get; set; }
}

namespace expression_members
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO 1. Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            var fruitsThatStartsWithL = fruits.Where(fruit => fruit.StartsWith('L')).ToList();

            //foreach (var fruit in fruitsThatStartsWithL)
            //{
            //    Console.WriteLine(fruit);
            //}

            //TODO  2. Which of the following numbers are multiples of 4 or 6
            List<int> mixedNumbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            var multiplesOf4Or6 = mixedNumbers.Where(number => number % 4 == 0 || number % 6 == 0).ToList();

            //foreach (var number in multiplesOf4Or6)
            //{
            //    Console.WriteLine(number);
            //}


            //TODO 3. Order the names by abc
            List<string> names = new List<string>()
            {
                "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                "Francisco", "Tre"
            };

            var orderedNames = names.OrderBy(name => name);

            //foreach (var name in orderedNames)
            //{
            //    Console.WriteLine(name);
            //}

            //TODO 4. Output how many numbers are in this list
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            Console.WriteLine(numbers.Count);

            //TODO 5. How much money have we made?
            List<double> purchases = new List<double>()
            {
                2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
            };

            Console.WriteLine(purchases.Sum());

            //TODO 6. What is our most expensive product?
            List<double> prices = new List<double>()
            {
                879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            };

            Console.WriteLine(prices.Max());

            

            //TODO 7. Store each number in a List until a perfect square is detected.
            List<int> wheresSquaredo = new List<int>()
            {
                66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
            };

            var perfectSquareIndex = wheresSquaredo.FindIndex(n => Math.Sqrt(n) == (int)Math.Sqrt(n));
            var beforePerfectSquare = wheresSquaredo.Where((number, index) => index < perfectSquareIndex);

            foreach (var c in beforePerfectSquare) { 
                Console.WriteLine(c);
            }

            var banksToNUmberOfMillionaires = new Dictionary<string, int>();
            


            //TODO 8. Display how many millionaires per bank.
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

            

            customers.ForEach(customer =>
            {
                if (!banksToNUmberOfMillionaires.Keys.ToList().Contains(customer.Bank))
                {
                    banksToNUmberOfMillionaires.Add(customer.Bank, 0);
                }

                if (customer.Balance >= 1_000_000)
                {
                    banksToNUmberOfMillionaires[customer.Bank]++;
                }
            });

            foreach (var bank in banksToNUmberOfMillionaires.Keys.ToList())
            {
                Console.WriteLine(bank + ": " + banksToNUmberOfMillionaires[bank]);
            }


        }
    }
}