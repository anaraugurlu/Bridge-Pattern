using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern
{
    class AdvancedRemote : Remote
    {

        public void Mute(bool mute)
        {
            Console.WriteLine($"Mute is{mute.ToString()}");
        }
    }
    public class Remote
    {
        public IDevice Device { get; set; }
        public void SetDevice(IDevice device)
        {
            Device = device;
        }
        public IDevice GetDevice()
        {
            return Device;
        }
        public void TogglePower(bool enable)
        {
            Device.IsEnabled(enable);

        }
        public void VolumeUp()
        {


            var old = Device.GetVolume();
            Device.SetVolume(old + 1);
        }
        public void ChannelUp()
        {
            var old = Device.GetChannel();
            Device.SetChannel(old + 1);
        }
        public void VolumeDown()
        {

            var old = Device.GetVolume();
            Device.SetVolume(old - 1);
        }
        public void ChannelDown()
        {


            var old = Device.GetChannel();
            Device.SetChannel(old - 1);
        }
    }

}
