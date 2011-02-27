using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware.Netduino;
using System.Threading;
using System;

namespace NetduinoApplication1.Samples
{
    class ToggleButton : ISample
    {
        private bool ledState;
        private InterruptPort button;
        private OutputPort led;

        public void Run()
        {
            // Set the initial state of the LED to on (true). 
            ledState = true;

            led = new OutputPort(Pins.ONBOARD_LED, ledState);

            button = new InterruptPort(
                Pins.ONBOARD_SW1,
                false,
                Port.ResistorMode.Disabled,
                Port.InterruptMode.InterruptEdgeBoth);

            // Bind the interrupt handler to the pin's interrupt event. 
            button.OnInterrupt += new NativeEventHandler(SwitchInterruptHandler);

            while (true)
            {
                Thread.Sleep(Timeout.Infinite);
            }
        }


        public void SwitchInterruptHandler(UInt32 data1, UInt32 data2, DateTime time)
        {
            button.DisableInterrupt();

            // Invert the previous state of the LED. 
            ledState = !ledState;

            // Set the LED to its new state. 
            led.Write(ledState);

            // Un-comment the following line if using level interrupts. 
            // button.ClearInterrupt(); 

            button.EnableInterrupt();
        }
    }
}
