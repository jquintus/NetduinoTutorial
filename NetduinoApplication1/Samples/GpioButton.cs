using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware.Netduino;

namespace NetduinoApplication1.Samples
{
    class GpioButton:ISample
    {
        public void Run()
        {

            OutputPort led = new OutputPort(Pins.ONBOARD_LED, false);

            InputPort D0 = new InputPort(Pins.GPIO_PIN_D0, false, Port.ResistorMode.Disabled);
            InputPort D1 = new InputPort(Pins.GPIO_PIN_D1, false, Port.ResistorMode.Disabled);
            InputPort D2 = new InputPort(Pins.GPIO_PIN_D2, false, Port.ResistorMode.Disabled);
            InputPort D3 = new InputPort(Pins.GPIO_PIN_D3, false, Port.ResistorMode.Disabled);
            InputPort D4 = new InputPort(Pins.GPIO_PIN_D4, false, Port.ResistorMode.Disabled);
            InputPort D5 = new InputPort(Pins.GPIO_PIN_D5, false, Port.ResistorMode.Disabled);
            InputPort D6 = new InputPort(Pins.GPIO_PIN_D6, false, Port.ResistorMode.Disabled);
            InputPort D7 = new InputPort(Pins.GPIO_PIN_D7, false, Port.ResistorMode.Disabled);
            InputPort D8 = new InputPort(Pins.GPIO_PIN_D8, false, Port.ResistorMode.Disabled);
            InputPort D9 = new InputPort(Pins.GPIO_PIN_D9, false, Port.ResistorMode.Disabled);
            InputPort D10 = new InputPort(Pins.GPIO_PIN_D10, false, Port.ResistorMode.Disabled);
            InputPort D11 = new InputPort(Pins.GPIO_PIN_D11, false, Port.ResistorMode.Disabled);
            InputPort D12 = new InputPort(Pins.GPIO_PIN_D12, false, Port.ResistorMode.Disabled);
            InputPort D13 = new InputPort(Pins.GPIO_PIN_D13, false, Port.ResistorMode.Disabled);

            bool buttonState = true;

            while (true)
            {
                buttonState = D0.Read() || D1.Read() || D2.Read() || D3.Read() || D4.Read() || D5.Read() || D6.Read() || D7.Read() || D8.Read() ||
                              D9.Read() || D10.Read() || D11.Read() || D12.Read() || D13.Read();
                led.Write(!buttonState);
            }
        }
    }
}
