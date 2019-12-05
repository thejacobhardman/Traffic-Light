using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traffic_Light
{
    class Program
    {
        static void Main(string[] args)
        {
            TrafficLight light = new TrafficLight(TrafficLightColor.Red);
            Console.WriteLine("Ready, Set, Go");
            light.CurrentColor = TrafficLightColor.Green;

            for (int i = 0; i < 15; i++)
            {
                light.change();
                Console.WriteLine(light);
            }

            Console.WriteLine("Press any key to close the program.");
            Console.ReadKey();
        }
    }
}
