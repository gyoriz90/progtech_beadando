using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progtech_2021_spring
{
    class HalogenBulbFactory:BulbFactory
    {
        private int _bulbPower;
        private int _bulbSize;

        public HalogenBulbFactory(int bulbPower, int bulbSize)
        {
            _bulbPower = bulbPower;
            _bulbSize = bulbSize;
        }
        public override Bulb GetBulb()
        {
            return new HalogenBulb(_bulbPower, _bulbSize);
        }
    }
}
