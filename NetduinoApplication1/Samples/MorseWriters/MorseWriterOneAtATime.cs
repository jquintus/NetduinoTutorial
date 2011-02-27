using System;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using System.Threading;

namespace NetduinoApplication1.Samples.MorseWriters
{
    public class MorseWriterOneAtATime:MorseWriter
    {
        private int currentLed;

        public MorseWriterOneAtATime(OutputPort[] leds) : base(leds) { }

        public override void Write(string message)
        {
            currentLed++;
            if (currentLed > Leds.Length) currentLed = 0;
            foreach (char c in message)
            {
                WriteOne(Leds[currentLed], c);
            }
        }

        protected void WriteOne(OutputPort led, char c)
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
