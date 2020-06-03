using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laba2_Part2.Models.Goods;

namespace Laba2_Part2.Models.Shop {
    class Shop {
        private List<IGoods> _goods;
        public string Name { get; private set; }

        public Shop(string name) {
            Name = name;
            _goods = new List<IGoods>();
        }

        public void Supply(IGoods[] newGoods) {
            _goods.AddRange(newGoods);
        }

        public void PrintGoods() {
            foreach (IGoods good in _goods) 
                Console.WriteLine(good);
        }

        public IGoods[] FindMadeBetween(DateTime from, DateTime to) {
            List<IGoods> res = new List<IGoods>();
            foreach (var item in _goods) 
                if (item.Stamp.Made >= from && item.Stamp.Made <= to)
                    res.Add(item);
            return res.ToArray();
        }
        public IGoods[] FindRemoveExpired() {
            List<IGoods> res = new List<IGoods>();
            for (int i = 0; i < _goods.Count; i++) {
                if (_goods[i].Stamp.Expires <= DateTime.Now) {
                    res.Add(_goods[i]);
                    _goods.RemoveAt(i);
                    i--;
                }
            }
               
            return res.ToArray();
        }

        private static int TypeComparer(IGoods fst, IGoods scnd) => fst.TYPE.CompareTo(scnd.TYPE);
        private static int PriceComparer(IGoods fst, IGoods scnd) => fst.Price.CompareTo(scnd.Price);

        public void SortByType() {
            _goods.Sort(TypeComparer);
        }
        public void SortByPrice() {
            _goods.Sort(PriceComparer);
        }

    }
}
