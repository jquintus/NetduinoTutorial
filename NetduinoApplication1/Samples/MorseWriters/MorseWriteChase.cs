using System;
using Microsoft.SPOT;
using System.Threading;
using Microsoft.SPOT.Hardware;

namespace NetduinoApplication1.Samples.MorseWriters
{
    public class MorseWriteChase : MorseWriter
    {
        public MorseWriteChase(OutputPort[] leds) : base(leds) { }


        public override void Write(string message)
        {
            foreach (char c in message)
            {
                WriteAllChase(c);
            }
        }

        private void WriteAllChase(char c)
        {
            int idx = Array.IndexOf(Letters, c.ToString().ToLower()[0]);
            if (idx < 0) return;

            foreach (char dotOrDash in MorseCode[idx])
            {
                foreach (OutputPort led in Leds)
                {
                    Toggle(led);
                    short span = 0;
                    if (dotOrDash == '.') span = DOT;
                    if (dotOrDash == '-') span = DASH;
                    Thread.Sleep(span);
                    Toggle(led);
                }
                Thread.Sleep(CHAR_GAP); // Always wait between a dot/dash
            }
            Thread.Sleep(WORD_GAP); // Always wait after a full character
        }
    }
}
