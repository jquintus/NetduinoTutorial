using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware.Netduino;


namespace NetduinoApplication1.Samples
{
    class GpioMixed : ISample
    {
        public void Run()
        {


            InputPort D0 = new InputPort(Pins.GPIO_PIN_D0, false, Port.ResistorMode.Disabled);
            InputPort D1 = new InputPort(Pins.GPIO_PIN_D1, false, Port.ResistorMode.Disabled);
            InputPort D2 = new InputPort(Pins.GPIO_PIN_D2, false, Port.ResistorMode.Disabled);
            InputPort D3 = new InputPort(Pins.GPIO_PIN_D3, false, Port.ResistorMode.Disabled);
            InputPort D4 = new InputPort(Pins.GPIO_PIN_D4, false, Port.ResistorMode.Disabled);
            InputPort D5 = new InputPort(Pins.GPIO_PIN_D5, false, Port.ResistorMode.Disabled);
            InputPort D6 = new InputPort(Pins.GPIO_PIN_D6, false, Port.ResistorMode.Disabled);
            //InputPort D7 = new InputPort(Pins.GPIO_PIN_D7, false, Port.ResistorMode.Disabled);
            //InputPort D8 = new InputPort(Pins.GPIO_PIN_D8, false, Port.ResistorMode.Disabled);
            //InputPort D9 = new InputPort(Pins.GPIO_PIN_D9, false, Port.ResistorMode.Disabled);
            //InputPort D10 = new InputPort(Pins.GPIO_PIN_D10, false, Port.ResistorMode.Disabled);
            //InputPort D11 = new InputPort(Pins.GPIO_PIN_D11, false, Port.ResistorMode.Disabled);
            //InputPort D12 = new InputPort(Pins.GPIO_PIN_D12, false, Port.ResistorMode.Disabled);
            //InputPort D13 = new InputPort(Pins.GPIO_PIN_D13, false, Port.ResistorMode.Disabled);

            //OutputPort D0 = new OutputPort(Pins.GPIO_PIN_D0, false);
            //OutputPort D1 = new OutputPort(Pins.GPIO_PIN_D1, false);
            //OutputPort D2 = new OutputPort(Pins.GPIO_PIN_D2, false);
            //OutputPort D3 = new OutputPort(Pins.GPIO_PIN_D3, false);
            //OutputPort D4 = new OutputPort(Pins.GPIO_PIN_D4, false);
            //OutputPort D5 = new OutputPort(Pins.GPIO_PIN_D5, false);
            //OutputPort D6 = new OutputPort(Pins.GPIO_PIN_D6, false);
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
                buttonState = D0.Read();
                D7.Write(!buttonState);
                //buttonState = D1.Read();
                //D8.Write(!buttonState);
                //buttonState = D2.Read();
                //D9.Write(!buttonState);
                //buttonState = D3.Read();
                //D10.Write(!buttonState);
                //buttonState = D4.Read();
                //D11.Write(!buttonState);
                //buttonState = D5.Read();
                //D12.Write(!buttonState);
                //buttonState = D6.Read();
                //D13.Write(!buttonState);
            }


        }
    }
}
