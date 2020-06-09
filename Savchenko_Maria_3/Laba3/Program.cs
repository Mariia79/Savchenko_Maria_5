using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3 {
    class Program {
        static void Main(string[] args) {
            List<int> list = new List<int>() { 20, 5, 6, 7, 8, 1, 3, 4, 11 };

            int max = list.Max();
            int min = list.Min();
            for (int i = 0; i < list.Count; i++) {
                if(list[i] == min) {
                    list[i] = max;
                    continue;
                }
                if(list[i] == max) 
                    list[i] = min;
                
            }

            foreach (int item in list) {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
    }
}
