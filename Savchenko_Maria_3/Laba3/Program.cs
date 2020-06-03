using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3 {
    class Program {
        static void Main(string[] args) {
            List<int> list = new List<int>() { 20, 5, 6, 7, 8, 1, 3, 4, 11 };
            int maxIndex = list.FindIndex((int a) => a == list.Max());
            int minIndex = list.FindIndex((int a) => a == list.Min());
            int c = list[minIndex];
            list[minIndex] = list[maxIndex];
            list[maxIndex] = c;

            foreach (int item in list) {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
    }
}
