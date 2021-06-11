using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progtech_2021_spring
{
    class NormalBulbFactory:BulbFactory
    {
        private int _bulbPower;
        private int _bulbSize;

        public NormalBulbFactory(int bulbPower, int bulbSize)
        {
            _bulbPower = bulbPower;
            _bulbSize = bulbSize;
        }
        public override Bulb GetBulb()
        {
            return new NormalBulb(_bulbPower, _bulbSize);
        }
    }
}
