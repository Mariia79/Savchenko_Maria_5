using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2_Part2.Models.Goods {
    class Bread : IGoods {
        
        public BreadType BreadType { get; set; }

        public override string TYPE => "BREAD";

        public Bread(string name, decimal price, string dealer, Stamp stamp, BreadType breadType = BreadType.White)
            : base(name, price, dealer, stamp) {

            this.BreadType = breadType;
        }
        public override string ToString() {
            return base.ToString() + BreadType;
        }
    }
}
