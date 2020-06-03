using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laba2.Models;

namespace Laba2 {
    class Program {
        static void Main(string[] args) {
            Bird bird = new Bird();
            bird.Attack();
            Console.WriteLine(new string('-', 20));
            bird.Eat();
            Console.WriteLine(new string('-', 20));
            bird.Fly();
            Console.WriteLine(new string('-', 20));
            bird.Sit();
            Console.ReadKey();
        }
    }
}
