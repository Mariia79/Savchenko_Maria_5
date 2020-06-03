using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2.Models {
    class Bird {
        private Wings Wings = new Wings();
        private Beak Beak = new Beak();

        public void Fly() {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("The bird is flying! ");
            Console.ResetColor();
            Wings.Open();
            for (int i = 0; i < 5; i++) {
                Wings.Swing();
            }
        }

        public void Sit() {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("The bird is sitting! ");
            Console.ResetColor();
            Wings.Close();
        }

        public void Eat() {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The bird is eatting! ");
            Console.ResetColor();
            Wings.Close();
            Beak.Open();
            for (int i = 0; i < 5; i++) {
                Beak.Bite();
            }
        }
        public void Attack() {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("The bird is attacking! ");
            Console.ResetColor();
            Beak.Open();
            Wings.Open();
            for (int i = 0; i < 5; i++) {
                Wings.Swing();
                Beak.Bite();
            }
        }
        public override string ToString() {
            return $"{Beak}\n{Wings}\n-------------- ";
        }
        public override int GetHashCode() {
            return Wings.GetHashCode() + Beak.GetHashCode();
        }
        public override bool Equals(object obj) {
            var cmp = (obj as Bird);
            return this.Wings.Equals(cmp.Wings) && this.Beak.Equals(cmp.Beak);
        }
    }
}
