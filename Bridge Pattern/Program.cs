using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern
{
    
    public interface IDevice
    {
        void IsEnabled(bool isenable);
        void Enable();
        void Disable();
        double  GetVolume();
        void SetVolume(double percent);
        double  GetChannel();
        void SetChannel(double channel);
    }





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
        public double  GetChannel()
        {
          return Channel ;
        }
        public double  GetVolume()
        {
            return Volume ;
        }
    }
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



        public double  GetVolume()
        {
            return volume;

        }

        public double  GetChannel()
        {
            return channel ;

        }
    }

     class AdvancedRemote:Remote 
    {
        
        public void Mute(bool mute)
        {
            Console.WriteLine($"Mute is{mute.ToString ()}");
        }
    }
 public   class Remote
    {
        public IDevice  Device  { get; set; }
    public void SetDevice(IDevice device)
        {
            Device = device;
        }
        public IDevice  GetDevice()
        {
            return Device;
        }
        public void TogglePower(bool enable) {
            Device.IsEnabled(enable);

        }
        public void VolumeUp() {


            var old = Device.GetVolume();
            Device.SetVolume(old + 1);
        }
        public void ChannelUp() { 
            var old = Device.GetChannel();
            Device.SetChannel(old + 1);
        }
        public void VolumeDown() {

            var old = Device.GetVolume();
            Device.SetVolume(old - 1);
        }
        public void ChannelDown() {


            var old = Device.GetChannel();
            Device.SetChannel(old - 1);
        }
    }
   
    class Program
    {
        static void Main(string[] args)
        {

            bool isEnable2 = false;
            bool isEnable = true;
            IDevice device = new Radio();
            AdvancedRemote tvRemote = new AdvancedRemote();
            Remote radioRemote = new Remote( );
            Console.WriteLine("Radio Remote");
            radioRemote.SetDevice(device);
            radioRemote.TogglePower(isEnable);
           radioRemote.VolumeDown(); 
            radioRemote.ChannelDown();
            radioRemote.TogglePower(isEnable2);
            Console.WriteLine("Tv Remote");
            tvRemote.SetDevice(device);
            tvRemote.TogglePower(isEnable);
            tvRemote.VolumeUp ();
            tvRemote.ChannelUp ();
            tvRemote.TogglePower(isEnable2);






            //radioRemote.Mute(isMute);
        }
    }
}
