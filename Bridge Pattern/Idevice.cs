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
        double GetVolume();
        void SetVolume(double percent);
        double GetChannel();
        void SetChannel(double channel);
    }
}
