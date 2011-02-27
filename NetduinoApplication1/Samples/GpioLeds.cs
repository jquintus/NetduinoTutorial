using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware.Netduino;

namespace NetduinoApplication1.Samples
{
    class GpioLeds:ISample
    {
        public void Run()
        {

            InputPort button = new InputPort(Pins.ONBOARD_SW1, false, Port.ResistorMode.Disabled);

            OutputPort D0 = new OutputPort(Pins.GPIO_PIN_D0, false);
            OutputPort D1 = new OutputPort(Pins.GPIO_PIN_D1, false);
            OutputPort D2 = new OutputPort(Pins.GPIO_PIN_D2, false);
            OutputPort D3 = new OutputPort(Pins.GPIO_PIN_D3, false);
            OutputPort D4 = new OutputPort(Pins.GPIO_PIN_D4, false);
            OutputPort D5 = new OutputPort(Pins.GPIO_PIN_D5, false);
            OutputPort D6 = new OutputPort(Pins.GPIO_PIN_D6, false);
            OutputPort D7 = new OutputPort(Pins.GPIO_PIN_D7, false);
            OutputPort D8 = new OutputPort(Pins.GPIO_PIN_D8, false);
            OutputPort D9 = new OutputPort(Pins.GPIO_PIN_D9, false);
            OutputPort D10 = new OutputPort(Pins.GPIO_PIN_D10, false);
            OutputPort D11 = new OutputPort(Pins.GPIO_PIN_D11, false);
            OutputPort D12 = new OutputPort(Pins.GPIO_PIN_D12, false);
            OutputPort D13 = new OutputPort(Pins.GPIO_PIN_D13, false);


            bool buttonState = true;

            while (true)
            {
                buttonState = button.Read();
                D0.Write(!buttonState);
                D1.Write(!buttonState);
                D2.Write(!buttonState);
                D3.Write(!buttonState);
                D4.Write(!buttonState);
                D5.Write(!buttonState);
                D6.Write(!buttonState);
                D7.Write(!buttonState);
                D8.Write(!buttonState);
                D9.Write(!buttonState);
                D10.Write(!buttonState);
                D11.Write(!buttonState);
                D12.Write(!buttonState);
                D13.Write(!buttonState);
            }

        }
    }
}
