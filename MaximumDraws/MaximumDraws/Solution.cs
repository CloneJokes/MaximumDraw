using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    public class Pairs
    {
        //constructor
        public Pairs(int n)
        {
            N = n;
        }
        //Getters and Setters
        //prop tab x 2
        public int N { get; set; }
        //Calculation
        public string FindTotalPairs()
        {
            var pairs = N + 1;
            return string.Format("{0}", pairs);
        }
        public static void Main(string[] args)
        {
            //t = number of test cases
            var t = int.Parse(Console.ReadLine());
            //this array list Pair contains coords
            var pair = new List<Pairs>();
            //for each test case, based on line "x" add the number of pairs into an array
            for (var i = 1; i <= t; i++)
            {
                var n = int.Parse(Console.ReadLine());
                pair.Add(new Pairs(n));
            }
            foreach (var pairs in pair)
            {
                Console.WriteLine(pairs.FindTotalPairs());// print out total pairs
            }
        }
    }
}
