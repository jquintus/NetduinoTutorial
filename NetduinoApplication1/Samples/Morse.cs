using System;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using System.Threading;
using SecretLabs.NETMF.Hardware.Netduino;

namespace NetduinoApplication1.Samples
{
    class Morse : ISample
    {
        public string Message { get; set; }
        private OutputPort[] leds { get; set; }
        private InterruptPort button { get; set; }
        private MorseWriter mw { get; set; }
        private object LockObj { get; set; }
        private bool IsRunning { get; set; }

        public Morse(string msg)
        {
            Message = msg;
            LockObj = new object();
            leds = new OutputPort[3];

            leds[0] = new OutputPort(Pins.GPIO_PIN_D12, true);
            leds[1] = new OutputPort(Pins.ONBOARD_LED, false);
            leds[2] = new OutputPort(Pins.GPIO_PIN_D1, true);

            button = new InterruptPort(Pins.ONBOARD_SW1, false, Port.ResistorMode.Disabled, Port.InterruptMode.InterruptEdgeHigh);
            button.OnInterrupt += new NativeEventHandler(button_OnInterrupt);
            mw = new MorseWriters.MorseWriteChase(leds);
        }

        private void doWork()
        {
            try
            {
                Debug.Print("Writing " + this.Message + " on thread ");
                mw.Write(Message);
            }
            catch (Exception ex)
            {
                Debug.Print("Error while doing work: " + ex.Message);
            }
            finally
            {
                IsRunning = false;
            }
        }

        void button_OnInterrupt(uint data1, uint data2, DateTime time)
        {
            Debug.Print("buttonPressed");
            if (IsRunning)
            {
                Debug.Print("We are already running, so do nothing");
                return;
            }
            lock (LockObj)
            {
                if (!IsRunning)
                {
                    IsRunning = true;
                    try
                    {
                        Thread workerThread = new Thread(new ThreadStart(doWork));
                        workerThread.Start();
                    }
                    catch (Exception ex)
                    {
                        IsRunning = false;
                        Debug.Print(ex.Message);
                    }
                }
            }

        }

        public void Run()
        {
            Thread.Sleep(Timeout.Infinite);
        }



    }

}
