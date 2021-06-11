using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace progtech_2021_spring
{
    class Program
    {
        static void Main(string[] args)
        {
            BulbFactory factory = null;
            Console.WriteLine("Add the type of bulb you would like to see: ");
            string temp = Console.ReadLine();

            switch (temp.ToLower())
            {
                case "ledbulb":
                    factory = new LedBulbFactory(20, 2);
                    break;
                case "halogenbulb":
                    factory = new HalogenBulbFactory(50, 5);
                    break;
                case "normalbulb":
                    factory = new NormalBulbFactory(100, 10);
                    break;
            }

            Bulb bulb = factory.GetBulb();
            Console.WriteLine("Your buld details are below:");
            Console.WriteLine("Bulb type: {0}\nBulb Power: {1}\nBulb Size: {2}",bulb.BulbType,bulb.BulbPower, bulb.BulbSize);
            Console.ReadKey();
        }
    }
}
