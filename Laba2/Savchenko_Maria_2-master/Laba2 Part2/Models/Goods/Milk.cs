using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2_Part2.Models.Goods {
    class Milk : IGoods {
        public decimal FatContent { get; set; }
        public override string TYPE => "MILK";

        public Milk(string name, decimal price, string dealer, Stamp stamp, decimal fatContent = 3.2M) 
            : base(name, price, dealer, stamp) {

            this.FatContent = fatContent;
        }

        public override string ToString() {
            return base.ToString() + FatContent + "%";
        }
    }
}
