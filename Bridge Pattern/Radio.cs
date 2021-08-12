using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern
{
    public class Radio : IDevice
    {
        public double Channel { get; set; } = 20;
        public double Volume { get; set; } = 100;
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
            Console.WriteLine($"  Disable Radio");
        }
        public void Enable()
        {
            Console.WriteLine($"  Enable Radio");
        }

        public void SetChannel(double channel)
        {
            Channel = channel;
            Console.WriteLine($"Radio channel : {channel}");

        }

        public void SetVolume(double volume)
        {
            Volume = volume;
            Console.WriteLine($"Radio volume : {volume}");

        }
        public double GetChannel()
        {
            return Channel;
        }
        public double GetVolume()
        {
            return Volume;
        }
    }
}
