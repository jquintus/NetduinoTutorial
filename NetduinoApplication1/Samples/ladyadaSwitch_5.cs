using System;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware.Netduino;
using System.Threading;

namespace NetduinoApplication1.Samples
{
    public class ladyadaSwitch_5:ISample
    {
        public void Run()
        {
            Debug.Print("Starting");

            InputPort button = new InputPort(Pins.ONBOARD_SW1, false, Port.ResistorMode.Disabled);
            button = new InputPort(Pins.GPIO_PIN_D2, false, Port.ResistorMode.Disabled);
            OutputPort led = new OutputPort(Pins.ONBOARD_LED, false);

            while (true)
            {
                bool state = !button.Read();
                Debug.Print(state ? "On" : "   Off");
                led.Write(state);
                Thread.Sleep(5);
            }

        }
    }
}
