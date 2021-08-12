using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge_Pattern
{
    
   
    

    
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
            tvRemote.Mute (isEnable );
            tvRemote.TogglePower(isEnable2);






          
        }
    }
}
