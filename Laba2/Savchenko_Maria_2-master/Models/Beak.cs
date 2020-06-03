using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2.Models {
    class Beak {
        public bool isOpen = false;
        public void Close() {
            isOpen = false;
            Console.WriteLine("Beak is closed!");
        }
        public void Open() {
            isOpen = true;
            Console.WriteLine("Beak is opened!");
        }
        public void Bite() {
            if (isOpen) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Beak has bitten!");
                Console.ResetColor();
            } else
                Console.WriteLine("Error, the beak has broken");
        }
        public override string ToString() {
            return "Beak is " + 
                (isOpen ? "opened!" : "closed");

        }
        public override int GetHashCode() {
            return base.GetHashCode();
        }
        public override bool Equals(object obj) {
            return this.isOpen.Equals((obj as Beak).isOpen);
        }
    }
}
