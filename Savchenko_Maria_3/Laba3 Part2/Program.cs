using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;


namespace Laba3_Part2 {
    class Program {
        static void Main(string[] args) {
            Dictionary<char, int> d1 = new Dictionary<char, int>(),
                                  d2 = new Dictionary<char, int>(),
                                  d3 = new Dictionary<char, int>();
            d1.Add('a', 100);
            d1.Add('b', 200);
            d1.Add('c', 300);
            //
            d2.Add('a', 300);
            d2.Add('b', 200);
            d2.Add('d', 400);

            foreach (KeyValuePair<char, int> item in d1) {
                var ValueToAdd = item.Value;
                if (d2.ContainsKey(item.Key))
                    ValueToAdd += d2[item.Key];
                d3.Add(item.Key, ValueToAdd);
            }
            foreach (KeyValuePair<char, int> item in d2) {
                if (!d3.ContainsKey(item.Key))
                    d3.Add(item.Key, item.Value);
            }
            foreach (var item in d3) {
                Console.WriteLine($"d3['{item.Key}'] = {item.Value}");
            }
            string jsonString = JsonConvert.SerializeObject(d3);
            File.WriteAllText("./dictionary.json", jsonString);
            Console.ReadKey();
        }
    }
}
