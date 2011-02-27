using System;
using System.Threading;
using System.IO.Ports;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware;
using SecretLabs.NETMF.Hardware.Netduino;
using System.Text;
using NetduinoApplication1.Samples;
using System.Collections;

namespace NetduinoApplication1
{
    public class Program
    {

        public static void Main()
        {
            ISample sample ;
            //sample = new BasicButton();
            //sample = new GpioButton();
            //sample = new GpioLeds();
            //sample = new GpioMixed();
            //sample = new ToggleButton();
            //sample = new Morse("Hello Ksenia");
            //sample = new Morse("SOS");
            sample = new ladyadaSwitch_5();

            sample.Run();

        }

    }

}