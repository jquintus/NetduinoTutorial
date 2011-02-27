using System;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using System.Threading;

namespace NetduinoApplication1.Samples.MorseWriters
{
    public class MorseWriteSerial : MorseWriter
    {
        public MorseWriteSerial(OutputPort[] leds) : base(leds) { }

        public override void Write(string message)
        {
            foreach (char c in message)
            {
                foreach (OutputPort item in Leds)
                {
                    WriteOne(item, c);
                }
            }
        }

        public void WriteOne(OutputPort led, char c)
        {
            int idx = Array.IndexOf(Letters, c.ToString().ToLower()[0]);
            if (idx < 0) return;

            foreach (char dotOrDash in MorseCode[idx])
            {
                Toggle(led);
                short span = 0;
                if (dotOrDash == '.') span = DOT;
                if (dotOrDash == '-') span = DASH;
                Thread.Sleep(span);
                Toggle(led);
                Thread.Sleep(CHAR_GAP); // Always wait between a dot/dash
            }
            Thread.Sleep(WORD_GAP); // Always wait after a full character
        }


    }
}
