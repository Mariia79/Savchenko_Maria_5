using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2.Models {
    class Wings {
        public bool isOpen = false;
        public void Close() {
            isOpen = false;
            Console.WriteLine("Wings is closed!");
        }
        public void Open() {
            isOpen = true;
            Console.WriteLine("Wings is opened!");
        }
        public void Swing() {
            if (isOpen) {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Wings has swinged!");
                Console.ResetColor();
            } else
                Console.WriteLine("Error, the wings has broken");
        }
        public override string ToString() {
            return $"Wings is " +
                (isOpen ? "opened!" : "closed").ToString();

        }
        public override int GetHashCode() {
            return base.GetHashCode();
        }
        public override bool Equals(object obj) {
            return this.isOpen.Equals((obj as Wings).isOpen);
        }
    }
}
