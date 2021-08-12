using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern
{
    public class Tv : IDevice
    {
        public double channel { get; set; } = 20;
        public double volume { get; set; } = 100;
        public void IsEnabled(bool isEnable)
        {
            if (isEnable == true)
            {
                Enable();
            }
            else
            {
                Disable();
            }
        }
        public void Disable()
        {
            Console.WriteLine($"Tv is Disabled");
        }
        public void Enable()
        {
            Console.WriteLine($"Tv is Enabled");
        }

        public void SetChannel(double _channel)
        {
            channel = _channel;
            Console.WriteLine($"Tv channel : {channel}");
        }

        public void SetVolume(double _volume)
        {
            volume = _volume;
            Console.WriteLine($"Radio volume : {_volume}");

        }



        public double GetVolume()
        {
            return volume;

        }

        public double GetChannel()
        {
            return channel;

        }
    }
}
