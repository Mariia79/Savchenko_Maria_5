using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3_Part3 {
    class Program {
        // Знайти кількість додатніх і суму непарних елементів списку.
        static void Main(string[] args) {
            List<int> list = new List<int>() { 1, 3, 9, 0, -5, -10, 7, -3 };

            var PositiveCount = (from element in list
                                 where element >= 0
                                 select element).Count();
            Console.WriteLine("Positive numbers: " + PositiveCount);
            var OddSum = (from element in list
                          where element % 2 != 0
                          select element).Sum();
            Console.WriteLine("Sum of odd elements: " + OddSum);
            Console.ReadKey();
        }
    }
}
