using System;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using System.Threading;

namespace NetduinoApplication1.Samples
{
    public abstract class MorseWriter
    {
        public OutputPort[] Leds { get; private set; }

        #region Protected Const
        protected const short DOT = 100;
        protected const short DASH = 300;
        protected const short CHAR_GAP = 300;
        protected const short WORD_GAP = 700;

        protected static Char[] Letters = new Char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g',
          'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u',
          'v', 'w', 'x', 'y', 'z', '0', '1', '2', '3', '4', '5', '6', '7', '8',
          '9', ' '};

        protected static String[] MorseCode = new String[] {".-", "-...", "-.-.",
          "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", 
          "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", 
          "...-", ".--", "-..-", "-.--", "--..", "-----", ".----", "..---", 
          "...--", "....-", ".....", "-....", "--...", "---..", "----.", " "};
        #endregion

        #region CTOR
        public MorseWriter(OutputPort[] leds)
        {
            if (leds == null) throw new ArgumentNullException("leds");
            this.Leds = leds;
        }
        #endregion

        public abstract void Write(string message);
        protected static void Toggle(OutputPort led) { led.Write(!led.Read()); }
    }

}
