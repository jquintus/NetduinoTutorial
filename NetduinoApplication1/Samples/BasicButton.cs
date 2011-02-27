using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware.Netduino;

namespace NetduinoApplication1.Samples
{
    class BasicButton:ISample
    {
        public void Run()
        {
            OutputPort led = new OutputPort(Pins.ONBOARD_LED, false);
            InputPort button = new InputPort(Pins.ONBOARD_SW1, false, Port.ResistorMode.Disabled);
            InputPort button2 = new InputPort(Pins.GPIO_PIN_A0, false, Port.ResistorMode.Disabled);

            bool buttonState = false;
            while (true)
            {

                buttonState = button.Read() || button2.Read();
                led.Write(buttonState);

            }
        }
    }
}
