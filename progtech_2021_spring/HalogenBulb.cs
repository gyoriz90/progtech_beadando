using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progtech_2021_spring
{
    class HalogenBulb:Bulb
    {
        private readonly string _bulbType;
        private int _bulbPower;
        private int _bulbSize;

        public HalogenBulb(int bulbPower, int bulbSize)
        {
            _bulbType = "Halogen Bulb";
            _bulbPower = bulbPower;
            _bulbSize = bulbSize;
        }
        public override string BulbType
        {
            get { return _bulbType; }
        }

        public override int BulbPower
        {
            get { return _bulbPower; }
            set { _bulbPower = value; }
        }
        public override int BulbSize
        {
            get { return _bulbSize; }
            set { _bulbSize = value; }
        }
    }
}
