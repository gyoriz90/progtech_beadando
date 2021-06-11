using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progtech_2021_spring
{
    abstract class Bulb
    {
        public abstract string BulbType { get; }
        public abstract int BulbPower { get; set; }
        public abstract int BulbSize { get; set; }
    }
}
