using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2024._09._30
{
    public class car
    {
        public static List<car> cars = new List<car>();
        public int id { get; set; }
        public string type { get; set; }
        public string model { get; set; }
        public string color { get; set; }
        public int year { get; set; }
        public int hp { get; set; }
    }
}
