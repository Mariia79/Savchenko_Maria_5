using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2_Part2.Models.Goods {
    abstract class IGoods {
        public Stamp Stamp { get; private set; }
        public string Name { get; private set; }
        public decimal Price { get; set; }
        public string Dealer { get; private set; }

        abstract public string TYPE {get; }

        public IGoods(string name, decimal price, string dealer, Stamp stamp) {
            this.Name = name;
            this.Price = price;
            this.Dealer = dealer;
            this.Stamp = stamp;
        }
        public override string ToString() {
            return TYPE + ": " +
                   Name + ", " +
                   Price + " " +
                   Dealer + " " +
                   this.Stamp.Made + " - " + this.Stamp.Expires + " ";
        }
    }
}
