using System;
using System.Collections.Generic;
using System.Text;

namespace TestInterface3
{
    interface RadioPlayerInterface
    {
        void Switch(Boolean on);
        void Return(double frequency);
        void setVolume(int loudness);
        void changeChannel();
    }
}
