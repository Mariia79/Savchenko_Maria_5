using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cord c = new Cord();
            Cord b = new Cord(5, 0);
            Cord a = new Cord(0, 5);
            Triangle tr1 = new Triangle(a, b, c);
            Triangle tr2 = new Triangle(new Cord(1, 1), new Cord(1, 5), new Cord(4, 1));
            tr1.Display("Tr1");
            tr2.Display("TR2");
            Console.WriteLine("TR1 == TR2 ? "+tr1.EqualTr(tr2));
            tr2.Rotation('A', 60);
            tr2.Display("Tr2");
            tr2.Rotation('A', -60);
            tr2.Display("Tr2");
            Console.ReadKey();
        }
    }
}
